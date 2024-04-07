namespace AssetTool
{
    [Location("void USkyAtmosphereComponent::Serialize(FArchive& Ar)")]
    public class USkyAtmosphereComponent : USceneComponent
    {
        public bool bIsAtmosphericFog = false;
        public FGuid bStaticLightingBuiltGUID;

        public new USkyAtmosphereComponent Read(BinaryReader reader)
        {
            base.Read(reader);
            var a = Supports.CustomVer(FUE5MainStreamObjectVersion.Enums.RemovedAtmosphericFog) && bIsAtmosphericFog;
            var b = !bIsAtmosphericFog;
            if (a || b)
            {
                reader.Read(ref bStaticLightingBuiltGUID);
            }
            return this;
        }
        public new void Write(BinaryWriter writer)
        {
            base.Write(writer);
            var a = Supports.CustomVer(FUE5MainStreamObjectVersion.Enums.RemovedAtmosphericFog) && bIsAtmosphericFog;
            var b = !bIsAtmosphericFog;
            if (a || b)
            {
                writer.Write(bStaticLightingBuiltGUID);
            }
        }
    }
}
