namespace AssetTool
{
    [Location("void ULocalLightComponent::Serialize(FArchive& Ar)")]
    public class ULocalLightComponent : ULightComponent
    {
        public new ULocalLightComponent Read(BinaryReader reader)
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
