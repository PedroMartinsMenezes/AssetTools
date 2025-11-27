namespace AssetTool
{
    [JsonAsset("SkyAtmosphereComponent")]
    public class USkyAtmosphereComponent : USceneComponent
    {
        public bool bIsAtmosphericFog;
        public FGuid bStaticLightingBuiltGUID;

        [Location("void USkyAtmosphereComponent::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
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