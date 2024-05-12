namespace AssetTool
{
    [Location("void UMaterialExpression::Serialize(FStructuredArchive::FRecord Record)")]
    public class UMaterialExpression : UObject
    {
        public new UMaterialExpression Move(Transfer transfer) => (UMaterialExpression)base.Move(transfer);
    }
}
