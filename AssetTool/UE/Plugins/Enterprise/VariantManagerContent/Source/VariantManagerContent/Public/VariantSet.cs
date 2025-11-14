namespace AssetTool
{
    [JsonAsset("VariantSet")]
    public class UVariantSet : UObject
    {
        public FText DisplayText;

        [Location("void UVariantSet::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref DisplayText);
            return this;
        }
    }
}