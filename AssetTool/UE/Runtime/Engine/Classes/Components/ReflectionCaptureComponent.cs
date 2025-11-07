namespace AssetTool
{
    [JsonAsset("ReflectionCaptureComponent")]
    public class UReflectionCaptureComponent : USceneComponent
    {
        public bool bLegacy;
        public FGuid SavedVersion;
        public float AverageBrightness;
        public int32 EndOffset;
        public bool bValid;
        public FReflectionCaptureMapBuildData LegacyMapBuildData;
        public uint8[] CompressedCapturedData;

        [Location("void UReflectionCaptureComponent::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            SerializeLegacyData(transfer);
            return this;
        }

        [Location("void UReflectionCaptureComponent::SerializeLegacyData(FArchive& Ar)")]
        private void SerializeLegacyData(Transfer transfer)
        {
            if (!transfer.Supports.MoveReflectionCaptureDataToMapBuildData)
            {
                if (transfer.Supports.VER_UE4_REFLECTION_CAPTURE_COOKING)
                {
                    transfer.Move(ref bLegacy);
                }
                if (transfer.Supports.VER_UE4_REFLECTION_DATA_IN_PACKAGES)
                {
                    transfer.Move(ref SavedVersion);
                    if (transfer.Supports.ReflectionCapturesStoreAverageBrightness)
                    {
                        transfer.Move(ref AverageBrightness);
                    }
                    transfer.Move(ref EndOffset);
                    FGuid LegacyReflectionCaptureVer = new FGuid("0c669396-9cb8-49ae-9f41-20ff5812f4d3");
                    if (SavedVersion.Value == LegacyReflectionCaptureVer.Value)
                    {
                        transfer.Move(ref bValid);
                        if (bValid)
                        {
                            LegacyMapBuildData ??= new();
                            if (transfer.Supports.CustomReflectionCaptureResolutionSupport)
                            {
                                transfer.Move(ref LegacyMapBuildData.CubemapSize);
                            }
                            transfer.Move(ref CompressedCapturedData);
                        }
                    }
                }
            }
        }
    }
}