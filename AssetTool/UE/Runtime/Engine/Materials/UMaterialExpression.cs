namespace AssetTool
{
    public class UMaterialExpression : UObject
    {
        [Location("void UMaterialExpression::Serialize(FStructuredArchive::FRecord Record)")]
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
