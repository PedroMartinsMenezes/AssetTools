namespace AssetTool
{
    public class FModelElement : ITransferible
    {
        public FMeshMapBuildData LegacyMapBuildData;
        public FGuid MapBuildDataId;
        public FObjectPtr Component;
        public FObjectPtr Material;
        public uint16[] Nodes;

        [Location("FArchive& operator<<(FArchive& Ar,FModelElement& Element)")]
        public ITransferible Move(Transfer transfer)
        {
            if (!transfer.Supports.MapBuildDataSeparatePackage)
            {
                LegacyMapBuildData ??= new();
                LegacyMapBuildData.MoveValue(transfer);
            }
            if (transfer.Supports.FixedBSPLightmaps)
            {
                transfer.Move(ref MapBuildDataId);
            }
            transfer.Move(ref Component);
            transfer.Move(ref Material);
            transfer.Move(ref Nodes);
            if (!transfer.Supports.MapBuildDataSeparatePackage)
            {
                LegacyMapBuildData ??= new();
                transfer.Move(ref LegacyMapBuildData.IrrelevantLights);
            }
            return this;
        }
    }
}