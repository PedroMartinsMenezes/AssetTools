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

        [JsonIgnore] public int Length => (Objects.Count == 0 ? Header.PackageFileSummary.TotalHeaderSize : (int)Objects[^1].NextOffset) + Footer.Length;

        public bool Move(Transfer transfer, string context)
        {
            List<bool> status = [];
            try
            {
                Log.Info($"\n{context} Header\n");
                MoveHeader(transfer);
                SetupObjects();
                LoadAllObjects(transfer, context, status);
                if (transfer.GlobalObjects.FileSize > AppConfig.MaxFileSize)
                {
                    Console.WriteLine($"Max File Size Exeeded: {transfer.GlobalObjects.FileSize}. File: {transfer.GlobalObjects.FileName}");
                    return true;
                }
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
                MoveHeader(transfer);
                SetupObjects();
                LoadAllObjects(transfer, context, status);
                if (transfer.GlobalObjects.FileSize > AppConfig.MaxFileSize)
                {
                    Console.WriteLine($"Max File Size Exeeded: {transfer.GlobalObjects.FileSize}. File: {transfer.GlobalObjects.FileName}");
                    return true;
                }
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
                    Log.Info($"[{i + 1,3}] {obj.Offset,7} - {obj.NextOffset,7} ({obj.Size,7}): {obj.Type} '{obj.Name}' {(!GlobalObjects.AssetMovers.ContainsKey(obj.Type) ? "?" : "")}");
                    transfer.Position = obj.Offset;

                    transfer.Move(ref obj);

                    transfer = currentTransfer;

                    bool success = CheckSize(transfer, obj) && obj.AutoCheck(transfer, obj.Type, transfer.Stream, [obj.Offset, obj.NextOffset]);
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
                Log.Error($"Wrong Transfer Size: Obj({obj.Type}) Expected({obj.NextOffset}) Actual({transfer.Position})");
                if (!AppConfig.ContinueAfterError)
                    throw new InvalidOperationException();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void MoveHeader(Transfer transfer)
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
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }
        }

        private void SetupObjects()
        {
            if (Header.ExportMap == default)
                return;
            Objects ??= Header.ExportMap.ObjectExports.Select((x, i) => new AssetObject
            {
                Index = i + 1,
                ClassIndex = x.ClassIndex.Index,
                Offset = x.SerialOffset,
                Size = x.SerialSize,
                ObjectFlags = x.ObjectFlags,
                ObjectName = GetObjectName(x),
                ClassName = GetClassName(x),
                Name = x.ObjectName.Value,
                //<
                SerializationBeforeSerializationDependencies = x.SerializationBeforeSerializationDependencies,
                SerializationBeforeCreateDependencies = x.SerializationBeforeCreateDependencies
                //>
            })
            .ToList();

            Objects.ForEach(x =>
            {
                if (x.ClassName == UBlueprintGeneratedClass.TypeName)
                {
                    x.Type ??= UObjectWithPad.TypeName;
                }
                else
                {
                    x.Type ??= x.ObjectName;
                }
            });
        }

        private string GetClassName(FObjectExport x)
        {
            int importIndex = x.ClassIndex.Index;
            if (importIndex > 0)
            {
                if (x.OuterIndex.Index == 0)
                    importIndex = -Header.ExportMap.ObjectExports[importIndex - 1].ClassIndex.Index - 1;
                else
                    importIndex = -Header.ExportMap.ObjectExports[importIndex - 1].SuperIndex.Index - 1;
            }
            else
            {
                importIndex = -importIndex - 1;
            }
            return Header.ImportMap.ObjectImports[importIndex].ClassName.Value;
        }

        private string GetObjectName(FObjectExport x)
        {
            int importIndex = x.ClassIndex.Index;
            if (importIndex > 0)
            {
                if (x.OuterIndex.Index == 0)
                    importIndex = -Header.ExportMap.ObjectExports[importIndex - 1].ClassIndex.Index - 1;
                else
                    importIndex = -Header.ExportMap.ObjectExports[importIndex - 1].SuperIndex.Index - 1;
            }
            else
            {
                importIndex = -importIndex - 1;
            }
            return Header.ImportMap.ObjectImports[importIndex].ObjectName.Value;
        }
    }
}
