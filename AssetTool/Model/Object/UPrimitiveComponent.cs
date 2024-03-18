namespace AssetTool
{
    [Location("void UPrimitiveComponent::Serialize(FArchive& Ar)")]
    public class UPrimitiveComponent : USceneComponent
    {
        public new UPrimitiveComponent Read(BinaryReader reader)
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
