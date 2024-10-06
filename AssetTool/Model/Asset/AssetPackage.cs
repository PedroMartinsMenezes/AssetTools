namespace AssetTool
{
    /// <summary>
    /// Represents the UASSET file
    /// </summary>
    public class AssetPackage
    {
        public AssetHeader Header = new();
        public List<AssetObject> Objects;
        public PadData Footer = new();

        public bool Move(Transfer transfer, string context)
        {
            List<bool> status = [];
            try
            {
                Log.Info($"\n{context}: Header\n");
                MoveHeader(transfer);
                SetupObjects();

                Log.WriteFileNumber = 1;
                Log.Info($"\n{context}: {Objects.Count} Components\n");
                for (int i = 0; i < Objects.Count; i++)
                {
                    try
                    {
                        AssetObject obj = Objects[i];
                        GlobalObjects.CurrentObject = obj;
                        Log.Info($"[{i + 1,3}] {obj.Offset,7} - {obj.NextOffset,7} ({obj.Size,7}): {obj.Type} {(!GlobalObjects.AssetMovers.ContainsKey(obj.Type) ? "(UObject)" : "")}");
                        transfer.Position = obj.Offset;

                        obj.Move(transfer);

                        bool success = obj.SelfCheck(obj.Type, transfer, [obj.Offset, obj.NextOffset]);
                        status.Add(success);
                    }
                    catch
                    {
                        status.Add(false);
                    }
                }
                GlobalObjects.CurrentObject = null;

                Footer.Move(GlobalObjects.Transfer);

                return status.TrueForAll(x => x);
            }
            catch (Exception ex)
            {
                Log.Error($"    Error at {transfer.Position}. {ex.Message}");
                return false;
            }
        }

        private void MoveHeader(Transfer transfer)
        {
            try
            {
                Header.Move(transfer);
                Header.SelfCheck("Header", transfer, [0, Header.PackageFileSummary.TotalHeaderSize]);

                if (AppConfig.SaveHeader)
                    Header.SaveToJson("C:/Temp/Header.json");
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }
        }

        private void SetupObjects()
        {
            if (Header.ExportMap is null)
                return;
            Objects ??= Header.ExportMap.ObjectExports.Select((x, i) => new AssetObject
            {
                Index = i + 1,
                ClassIndex = x.ClassIndex.Index,
                Offset = x.SerialOffset,
                Size = x.SerialSize,
                ObjectFlags = x.ObjectFlags,
                Type = x.ClassIndex.Index < 0 ?
                    Header.ImportMap.ObjectImports[-x.ClassIndex.Index - 1].ObjectName.Value :
                    Header.ExportMap.ObjectExports[+x.ClassIndex.Index + 0].ObjectName.Value
            })
            .ToList();
        }
    }
}
