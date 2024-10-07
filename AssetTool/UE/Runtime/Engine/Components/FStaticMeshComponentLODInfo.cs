namespace AssetTool
{
    public class FStaticMeshComponentLODInfo : ITransferible
    {
        public FStripDataFlags StripFlags;
        public FMeshMapBuildData LegacyMapBuildData;
        public FGuid MapBuildDataId;
        public byte bLoadVertexColorData;
        public FColorVertexBuffer OverrideVertexColors;

        [Location("FArchive& operator<<(FArchive& Ar,FStaticMeshComponentLODInfo& I)")]
        public ITransferible Move(Transfer transfer)
        {
            const byte OverrideColorsStripFlag = 1;
            transfer.Move(ref StripFlags);

            if (!StripFlags.IsDataStrippedForServer())
            {
                if (!Supports.MapBuildDataSeparatePackage)
                {
                    LegacyMapBuildData ??= new();
                    LegacyMapBuildData.MoveValue(transfer);
                }
                else
                {
                    transfer.Move(ref MapBuildDataId);
                }
            }

            if (!StripFlags.IsClassDataStripped(OverrideColorsStripFlag))
            {
                transfer.Move(ref bLoadVertexColorData);
                if (bLoadVertexColorData == 1)
                {
                    transfer.Move(ref OverrideVertexColors);
                }
            }

            return this;
        }
    }
}
