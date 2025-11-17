using System.Text.Json.Serialization;

namespace AssetTool
{
    /// <summary>
    /// Represents the UASSET file
    /// </summary>
    public class AssetPackage
    {
        public AssetHeader Header = new();
        public List<AssetObject> Objects;
        public FooterData Footer = new();
        [JsonIgnore] public bool VersionIsTooOld => Header.PackageFileSummary.FileVersionUE.FileVersionUE4 < EUnrealEngineObjectUE4Version.VER_UE4_OLDEST_LOADABLE_PACKAGE;

        [JsonIgnore] public int Length => (Objects.Count == 0 ? Header.PackageFileSummary.TotalHeaderSize : (int)Objects[^1].NextOffset) + Footer.Length;

        public bool Move(Transfer transfer, string context)
        {
            List<bool> status = [];
            try
            {
                Log.Info($"\n{context} Header\n");
                bool success = MoveHeader(transfer);
                if (!success)
                {
                    return false;
                }

                SetupObjects();
                LoadAllObjects(transfer, context, status);

                if (!AppConfig.DebugIgnoreAssetPackageFooter)
                {
                    Footer.Move(transfer, (int)transfer.Length - (int)transfer.Position);
                }
                return status.TrueForAll(x => x);
            }
            catch (Exception ex)
            {
                Log.Error($"    Error at {transfer.Position}. {ex.Message}");
                return false;
            }
        }

        public async Task<bool> MoveAsync(Transfer transfer, string context)
        {
            List<bool> status = [];
            try
            {
                Log.Info($"\n{context} Header\n");
                bool success = MoveHeader(transfer);
                if (!success)
                {
                    return false;
                }

                SetupObjects();
                LoadAllObjects(transfer, context, status);

                if (!AppConfig.DebugIgnoreAssetPackageFooter)
                {
                    Footer.Move(transfer, (int)transfer.Length - (int)transfer.Position);
                }
                return await Task.FromResult(status.TrueForAll(x => x));
            }
            catch (Exception ex)
            {
                Log.Error($"    Error at {transfer.Position}. {ex.Message}");
                return false;
            }
        }

        [Location("void FLinkerLoad::LoadAllObjects(bool bForcePreload)")]
        private void LoadAllObjects(Transfer transfer, string context, List<bool> status)
        {
            Log.WriteFileNumber = 1;
            Log.Info($"\n{context} Objects: {Objects.Count}\n");
            for (int i = 0; i < Objects.Count; i++)
            {
                try
                {
                    Transfer currentTransfer = transfer;

                    AssetObject obj = Objects[i];
                    transfer.GlobalObjects.CurrentObject = obj;
                    Log.Info($"[{i + 1,3}] {obj.Offset,7} - {obj.NextOffset,7} ({obj.Size,7}): {obj.ClassName} '{obj.ObjectName}' {(!GlobalObjects.AssetMovers.ContainsKey(obj.ClassName) ? "?" : "")}");
                    transfer.Position = obj.Offset;

                    transfer.Move(ref obj);

                    transfer = currentTransfer;

                    bool success = CheckSize(transfer, obj) && obj.AutoCheck(transfer, obj.ClassName, transfer.Stream, [obj.Offset, obj.NextOffset]);
                    status.Add(success);
                }
                catch
                {
                    if (!AppConfig.ContinueAfterError)
                    {
                        throw;
                    }
                    status.Add(false);
                }
            }
            transfer.GlobalObjects.CurrentObject = default;
        }

        private static bool CheckSize(Transfer transfer, AssetObject obj)
        {
            if (obj.NextOffset != transfer.Position)
            {
                Log.Error($"Wrong Transfer Size: Obj({obj.ClassName}) Expected({obj.NextOffset}) Actual({transfer.Position})");
                if (!AppConfig.ContinueAfterError)
                    throw new InvalidOperationException();
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool MoveHeader(Transfer transfer)
        {
            try
            {
                transfer.Move(ref Header);
                Header.AutoCheck(transfer, "Header", transfer.Stream, [0, Header.PackageFileSummary.TotalHeaderSize]);
                if (AppConfig.DebugSaveHeader && transfer.IsReading)
                {
                    string name = transfer.GlobalObjects.FileName.NameOnly();
                    string suffix = transfer.GlobalObjects.FileName.Hash();
                    Header.SaveToJson($"C:/Temp/Header_{name}_{suffix}.json", transfer);
                }
                return true;
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                return false;
            }
        }

        private void SetupObjects()
        {
            if (Header.ExportMap == default)
                return;
            Objects ??= Header.ExportMap.ObjectExports.Select((x, i) => new AssetObject
            {
                Index = i + 1,
                Offset = x.SerialOffset,
                Size = x.SerialSize,
                ObjectFlags = x.ObjectFlags,
                ObjectName = GetObjectName(x),
                ClassName = GetClassName(x),
                SuperName = GetSuperName(x),
                //<
                SerializationBeforeSerializationDependencies = x.SerializationBeforeSerializationDependencies,
                SerializationBeforeCreateDependencies = x.SerializationBeforeCreateDependencies
                //>
            })
            .ToList();
        }

        private string GetClassName(FObjectExport export)
        {
            FObjectImport import = null;
            (int classIndex, int outerIndex) = (export.ClassIndex.Index, export.OuterIndex.Index);
            if (classIndex > 0)
            {
                if (outerIndex == 0)
                    classIndex = -Header.ExportMap.ObjectExports[classIndex - 1].ClassIndex.Index - 1;
                else
                    classIndex = -Header.ExportMap.ObjectExports[classIndex - 1].SuperIndex.Index - 1;
                import = Header.ImportMap.ObjectImports[classIndex];
            }
            else if (classIndex < 0)
            {
                classIndex = -classIndex - 1;
                import = Header.ImportMap.ObjectImports[classIndex];
            }
            return import is null ? null : import.ClassName.Value == "Class" ? import.ObjectName.Value : import.ClassName.Value;
        }

        private string GetSuperName(FObjectExport export)
        {
            FObjectImport import = null;
            if (export.SuperIndex.Index < 0)
            {
                import = Header.ImportMap.ObjectImports[-export.SuperIndex.Index - 1];
            }
            return import is null ? null : import.ClassName.Value == "Class" ? import.ObjectName.Value : import.ClassName.Value;
        }

        private static string GetObjectName(FObjectExport x)
        {
            return x.ObjectName.Value;
        }

        public bool IsBlueprint()
        {
            return Header.AssetRegistryData.ObjectPackageData.Exists(x => x.ObjectClassName.Value == "/Script/Engine.Blueprint");
        }

        public string GetTypeNameFromPackageIndex(int index)
        {
            string typeName = null;
            if (index == 0)
            {
                return typeName;
            }
            else if (index < 0)
            {
                index = -1 * index - 1;
                typeName = index < Header.ImportMap.ObjectImports.Count ? Header.ImportMap.ObjectImports[index].ObjectName.Value : null;
                return typeName;
            }
            else
            {
                index = index - 1;
                int importIndex = Header.ExportMap?.ObjectExports[index]?.ClassIndex?.Index ?? 0;
                while (importIndex > 0)
                {
                    importIndex = Header.ExportMap.ObjectExports[importIndex - 1]?.ClassIndex?.Index ?? 0;
                }
                if (importIndex < 0)
                {
                    index = -1 * importIndex - 1;
                    typeName = index < Header.ImportMap.ObjectImports.Count ? Header.ImportMap.ObjectImports[index].ObjectName.Value : null;
                    return typeName;
                }
                else
                {
                    return typeName;
                }
            }
        }
    }
}
