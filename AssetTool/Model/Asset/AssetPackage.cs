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

        [JsonIgnore] public bool VersionIsTooOld => Header.PackageFileSummary.FileVersionUE.FileVersionUE4 != EUnrealEngineObjectUE4Version.UNKNOWN && Header.PackageFileSummary.FileVersionUE.FileVersionUE4 < EUnrealEngineObjectUE4Version.VER_UE4_OLDEST_LOADABLE_PACKAGE;

        [JsonIgnore] public int Length => (Objects is null || Objects.Count == 0 ? Header.PackageFileSummary.TotalHeaderSize : (int)Objects[^1].NextOffset) + Footer.Length;

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
                if (Header.IsHeaderOnly)
                {
                    return true;
                }

                SetupObjects();
                LoadAllObjects(transfer, context, status);

                if (!transfer.AppConfig.DebugIgnoreAssetPackageFooter)
                {
                    int size = transfer.GlobalObjects.FileSize - (int)transfer.Position;
                    Footer.Move(transfer, size);
                }
                return status.TrueForAll(x => x);
            }
            catch (Exception ex)
            {
                Log.Error($"    Error at {transfer.Position}. {ex.Message}");
                return false;
            }
        }

        #region Reading Asset Type
        public bool IsBlueprint(Transfer transfer) => IsAssetType(transfer, "Blueprint", "/Script/Engine.Blueprint");

        public bool IsAnimBlueprint(Transfer transfer) => IsAssetType(transfer, "AnimBlueprint", "/Script/Engine.AnimBlueprint");

        public bool IsAnimSequence(Transfer transfer) => IsAssetType(transfer, "AnimSequence", "/Script/Engine.AnimSequence");

        public bool IsBlendSpace1D(Transfer transfer) => IsAssetType(transfer, "BlendSpace1D", "/Script/Engine.BlendSpace1D");

        public bool IsStaticMesh(Transfer transfer) => IsAssetType(transfer, "StaticMesh", "/Script/Engine.StaticMesh");

        public bool IsTexture2D(Transfer transfer) => IsAssetType(transfer, "Texture2D", "/Script/Engine.Texture2D");

        public bool IsMaterial(Transfer transfer) => IsAssetType(transfer, "Material", "/Script/Engine.Material");

        public bool IsPaperSprite(Transfer transfer) => IsAssetType(transfer, "PaperSprite", "/Script/Engine.PaperSprite");

        public bool IsObjectRedirector(Transfer transfer) => IsAssetType(transfer, "ObjectRedirector", "/Script/Engine.ObjectRedirector");

        public bool IsPaperFlipbook(Transfer transfer) => IsAssetType(transfer, "PaperFlipbook", "/Script/Engine.PaperFlipbook");

        public bool IsMaterialInstanceConstant(Transfer transfer) => IsAssetType(transfer, "MaterialInstanceConstant", "/Script/Engine.MaterialInstanceConstant");

        public bool IsCurveLinearColor(Transfer transfer) => IsAssetType(transfer, "CurveLinearColor", "/Script/Engine.CurveLinearColor");

        public bool isCurveFloat(Transfer transfer) => IsAssetType(transfer, "CurveFloat", "/Script/Engine.CurveFloat");

        public bool IsUserDefinedStruct(Transfer transfer) => IsAssetType(transfer, "UserDefinedStruct", "/Script/Engine.UserDefinedStruct");

        public bool IsAssetType(Transfer transfer, params string[] assetTypes)
        {
            try
            {
                if (!MoveHeader(transfer))
                {
                    return false;
                }
                return Header.AssetRegistryData.ObjectPackageData.Exists(x => assetTypes.Contains(x.ObjectClassName.Value));
            }
            catch (Exception ex)
            {
                Log.Error($"    Error at {transfer.Position}. {ex.Message}");
                return false;
            }
        }

        public string GetAssetType(Transfer transfer, params string[] assetTypes)
        {
            try
            {
                if (!MoveHeader(transfer) || Header.AssetRegistryData.ObjectPackageData is null || Header.AssetRegistryData.ObjectPackageData.Count == 0)
                {
                    return "";
                }
                return Header.AssetRegistryData.ObjectPackageData[0].ObjectClassName.Value.Replace("/Script/Engine.", "");
            }
            catch (Exception ex)
            {
                Log.Error($"    Error at {transfer.Position}. {ex.Message}");
                return "";
            }
        }
        #endregion

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
                if (Header.IsHeaderOnly)
                {
                    return true;
                }

                SetupObjects();
                LoadAllObjects(transfer, context, status);

                if (!transfer.AppConfig.DebugIgnoreAssetPackageFooter)
                {
                    int size = transfer.GlobalObjects.FileSize - (int)transfer.Position;
                    Footer.Move(transfer, size);
                }
                return await Task.FromResult(status.TrueForAll(x => x));
            }
            catch (Exception ex)
            {
                Log.Error($"    Error at {transfer.Position}. {ex.Message}");
                return false;
            }
        }

        // Only large packages are split: smaller ones already run in parallel with other files, and splitting
        // them just adds overhead (measured on Test_UE56_Assets: 1 MB was slower, 16 MB kept the same total time)
        private const int ParallelExportsMinFileSize = 16 * 1024 * 1024;

        [Location("void FLinkerLoad::LoadAllObjects(bool bForcePreload)")]
        private void LoadAllObjects(Transfer transfer, string context, List<bool> status)
        {
            Log.WriteFileNumber = 1;
            Log.Info($"\n{context} Objects: {Objects.Count}\n");
            if (CanMoveExportsInParallel(transfer))
            {
                MoveExportsInParallel(transfer, status);
                return;
            }
            for (int i = 0; i < Objects.Count; i++)
            {
                try
                {
                    Transfer currentTransfer = transfer;

                    AssetObject obj = Objects[i];
                    transfer.GlobalObjects.CurrentObject = obj;

                    string baseType = GlobalObjects.GetRecognizedBaseClass(obj.ClassName);

                    Log.Info($"[{i + 1,3}] {obj.Offset,7} - {obj.NextOffset,7} ({obj.Size,7}): {obj.ClassName} '{obj.ObjectName}' {baseType}");
                    transfer.Position = obj.Offset;

                    obj.Move(transfer);

                    transfer = currentTransfer;

                    bool success = CheckSize(transfer, obj) && obj.AutoCheck(transfer, obj.ClassName, transfer.Stream, [obj.Offset, obj.NextOffset]);
                    status.Add(success);
                }
                catch
                {
                    if (!transfer.AppConfig.ContinueAfterError)
                    {
                        throw;
                    }
                    status.Add(false);
                }
            }
            transfer.GlobalObjects.CurrentObject = default;
        }

        private bool CanMoveExportsInParallel(Transfer transfer)
        {
            AppConfig config = transfer.AppConfig;
            if (Objects.Count < 2 || transfer.GlobalObjects.FileSize < ParallelExportsMinFileSize)
                return false;
            if (config.DebugCheckMember || config.DebugSaveMember || config.AutoCheckBinaryWriter)
                return false;
            return transfer.IsReading
                ? transfer.Stream is MemoryStream input && input.TryGetBuffer(out _)
                : transfer.Stream is MemoryStream;
        }

        /// <summary>
        /// Exports are independent and their offsets/sizes come from the header, so each one is moved by its own
        /// transfer: reading from its own view of the input bytes, or writing to its own buffer that is copied
        /// into the output at the export offset afterwards. Per-export caches are merged in export order, which
        /// gives the same result as moving the exports one after the other.
        /// </summary>
        private void MoveExportsInParallel(Transfer transfer, List<bool> status)
        {
            int count = Objects.Count;
            Transfer[] workers = new Transfer[count];
            bool[] results = new bool[count];
            Dictionary<string, GlobalTypeName>[] typeNames = new Dictionary<string, GlobalTypeName>[count];
            HashSet<string>[] unicodeStrings = new HashSet<string>[count];
            transfer.writer?.Flush();
            ArraySegment<byte> input = default;
            if (transfer.IsReading)
                ((MemoryStream)transfer.Stream).TryGetBuffer(out input);

            try
            {
                Parallel.For(0, count, i =>
                {
                    AssetObject obj = Objects[i];
                    GlobalObjects globals = transfer.IsReading
                        ? transfer.GlobalObjects.CloneForWorker(typeNames[i] = [], unicodeStrings[i] = [])
                        : transfer.GlobalObjects.CloneForWorker(transfer.GlobalObjects.GlobalTypeNames, transfer.GlobalObjects.UnicodeStrings);
                    Transfer worker = transfer.IsReading
                        ? new TransferReader(new BinaryReader(new MemoryStream(input.Array, input.Offset, input.Count, false, true)), transfer.AppConfig)
                        : new TransferWriter(new BinaryWriter(new OffsetStream(obj.Offset)), transfer, transfer.FromJson, transfer.FromAutoCheck);
                    worker.InitializeWorker(transfer, globals);
                    workers[i] = worker;
                    try
                    {
                        globals.CurrentObject = obj;
                        string baseType = GlobalObjects.GetRecognizedBaseClass(obj.ClassName);
                        Log.Info($"[{i + 1,3}] {obj.Offset,7} - {obj.NextOffset,7} ({obj.Size,7}): {obj.ClassName} '{obj.ObjectName}' {baseType}");
                        worker.Position = obj.Offset;
                        obj.Move(worker);
                        results[i] = CheckSize(worker, obj) && obj.AutoCheck(worker, obj.ClassName, worker.Stream, [obj.Offset, obj.NextOffset]);
                    }
                    catch
                    {
                        if (!transfer.AppConfig.ContinueAfterError)
                            throw;
                        results[i] = false;
                    }
                });

                if (transfer.IsReading)
                {
                    MergeWorkerCaches(transfer.GlobalObjects, typeNames, unicodeStrings);
                    transfer.Position = workers[^1].Position;
                }
                else
                {
                    CopyWorkerOutputs(transfer, workers);
                }
                status.AddRange(results);
            }
            finally
            {
                foreach (Transfer worker in workers)
                    worker?.Dispose();
                transfer.GlobalObjects.CurrentObject = default;
            }
        }

        private static void MergeWorkerCaches(GlobalObjects globals, Dictionary<string, GlobalTypeName>[] typeNames, HashSet<string>[] unicodeStrings)
        {
            // Export order + first one wins: the same entries, values and insertion order as a sequential move
            for (int i = 0; i < typeNames.Length; i++)
            {
                if (typeNames[i] is null)
                    continue;
                foreach (KeyValuePair<string, GlobalTypeName> entry in typeNames[i])
                    globals.GlobalTypeNames.TryAdd(entry.Key, entry.Value);
                globals.UnicodeStrings.UnionWith(unicodeStrings[i]);
            }
        }

        private void CopyWorkerOutputs(Transfer transfer, Transfer[] workers)
        {
            Stream output = transfer.Stream;
            for (int i = 0; i < workers.Length; i++)
            {
                workers[i].writer.Flush();
                OffsetStream exportStream = (OffsetStream)workers[i].Stream;
                output.Position = exportStream.BaseOffset;
                output.Write(exportStream.WrittenBytes);
            }
            transfer.Position = workers[^1].Position;
        }

        private static bool CheckSize(Transfer transfer, AssetObject obj)
        {
            if (obj.NextOffset != transfer.Position)
            {
                Log.Error($"Wrong Transfer Size: Obj({obj.ClassName}) Expected({obj.NextOffset}) Actual({transfer.Position})");
                if (!transfer.AppConfig.ContinueAfterError)
                    throw new InvalidOperationException();
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool MoveHeader(Transfer transfer)
        {
            try
            {
                transfer.Move(ref Header);
                Header.AutoCheck(transfer, "Header", transfer.Stream, [0, Header.PackageFileSummary.TotalHeaderSize]);
                if (transfer.AppConfig.DebugSaveHeader && transfer.IsReading)
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
                SerializationBeforeSerializationDependencies = x.PreloadDependencies.SerializationBeforeSerializationDependencies,
                SerializationBeforeCreateDependencies = x.PreloadDependencies.SerializationBeforeCreateDependencies
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
