namespace AssetTool
{
    public class FStaticMeshComponentLODInfo : ITransferible
    {
        public FStripDataFlags StripFlags;
        public FMeshMapBuildData LegacyMapBuildData;
        public FGuid OriginalMapBuildDataId;
        public byte bLoadVertexColorData;
        public FColorVertexBuffer OverrideVertexColors;
        public List<FPaintedVertex> PaintedVertices;

        [Location("FArchive& operator<<(FArchive& Ar,FStaticMeshComponentLODInfo& I)")]
        public ITransferible Move2(Transfer transfer)
        {
            const byte OverrideColorsStripFlag = 1;
            transfer.Move(ref StripFlags);

            if (!StripFlags.IsAudioVisualDataStripped())
            {
                if (!transfer.Supports.MapBuildDataSeparatePackage)
                {
                    LegacyMapBuildData ??= new();
                    LegacyMapBuildData.MoveValue(transfer);
                }
                else
                {
                    transfer.Move(ref OriginalMapBuildDataId);
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

            if (!StripFlags.IsEditorDataStripped())
            {
                transfer.Move(ref PaintedVertices);
            }

            return this;
        }
    }
}
