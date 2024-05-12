namespace AssetTool
{
    [Location("void UMaterialExpression::Serialize(FStructuredArchive::FRecord Record)")]
    public class UMaterialExpression : UObject
    {
        public UMaterialExpression Read(BinaryReader reader)
        {
            base.Move(GlobalObjects.Transfer);
            return this;
        }
        public void Write(BinaryWriter writer)
        {
            base.Move(GlobalObjects.Transfer);
        }
    }
}
