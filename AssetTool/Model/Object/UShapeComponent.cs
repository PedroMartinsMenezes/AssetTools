namespace AssetTool
{
    [Location("void UShapeComponent::Serialize(FArchive& Ar)")]
    public class UShapeComponent : UPrimitiveComponent
    {
        public new UShapeComponent Read(BinaryReader reader)
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
