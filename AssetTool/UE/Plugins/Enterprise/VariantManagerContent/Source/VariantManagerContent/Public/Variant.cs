namespace AssetTool
{
    [JsonAsset("Variant")]
    public class UVariant : UObject
    {
        public FText DisplayText;

        [Location("void UVariant::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            if (transfer.Supports.CategoryFlagsAndManualDisplayText)
            {
                transfer.Move(ref DisplayText);
            }
            return this;
        }
    }
}