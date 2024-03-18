namespace AssetTool
{
    [Location("void UPointLightComponent::Serialize(FArchive& Ar)")]
    public class USpotLightComponent : UPointLightComponent
    {
        public new const string TypeName = "SpotLightComponent";

        public new USpotLightComponent Read(BinaryReader reader)
        {
            base.Read(reader);
            return this;
        }
        public new void Write(BinaryWriter writer)
        {
            base.Write(writer);
        }
    }
}
