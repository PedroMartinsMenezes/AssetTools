namespace AssetTool
{
    [Location("void UMaterialExpression::Serialize(FStructuredArchive::FRecord Record)")]
    public class UMaterialExpression : UObject
    {
        public UMaterialExpression Read(BinaryReader reader)
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
