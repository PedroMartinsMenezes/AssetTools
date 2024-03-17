namespace AssetTool
{
    [Location("void UPointLightComponent::Serialize(FArchive& Ar)")]
    public class UPointLightComponent : ULocalLightComponent
    {
        public new const string TypeName = "PointLightComponent";

        public new UPointLightComponent Read(BinaryReader reader)
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
