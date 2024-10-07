namespace AssetTool
{
    public class USkyAtmosphereComponent : USceneComponent
    {
        public bool bIsAtmosphericFog = false;
        public FGuid bStaticLightingBuiltGUID;

        [Location("void USkyAtmosphereComponent::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            var a = Supports.CustomVer(FUE5MainStreamObjectVersion.Enums.RemovedAtmosphericFog) && bIsAtmosphericFog;
            var b = !bIsAtmosphericFog;
            if (a || b)
            {
                transfer.Move(ref bStaticLightingBuiltGUID);
            }
            return this;
        }
    }
}
