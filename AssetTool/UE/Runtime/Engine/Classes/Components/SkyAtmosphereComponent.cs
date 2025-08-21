namespace AssetTool
{
    [JsonAsset("SkyAtmosphere")]
    public class ASkyAtmosphere : AInfo
    {
    }

    [JsonAsset("SkyAtmosphereComponent")]
    public class USkyAtmosphereComponent : USceneComponent
    {
        public bool bIsAtmosphericFog;
        public FGuid bStaticLightingBuiltGUID;

        [Location("void USkyAtmosphereComponent::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            var a = transfer.Supports.RemovedAtmosphericFog && bIsAtmosphericFog;
            var b = !bIsAtmosphericFog;
            if (a || b)
            {
                transfer.Move(ref bStaticLightingBuiltGUID);
            }
            return this;
        }
    }
}