namespace AssetTool
{
    [JsonAsset("SkyAtmosphere")]
    public class ASkyAtmosphere : AInfo
    {
    }

    [JsonAsset("SkyAtmosphereComponent")]
    public class USkyAtmosphereComponent : USceneComponent
    {
        public bool bIsAtmosphericFog = false;
        public FGuid bStaticLightingBuiltGUID;

        [Location("void USkyAtmosphereComponent::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            var a = Supports.RemovedAtmosphericFog && bIsAtmosphericFog;
            var b = !bIsAtmosphericFog;
            if (a || b)
            {
                transfer.Move(ref bStaticLightingBuiltGUID);
            }
            return this;
        }
    }
}