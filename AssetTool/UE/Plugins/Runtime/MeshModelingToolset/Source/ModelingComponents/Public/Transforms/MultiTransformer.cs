namespace AssetTool
{
    [JsonAsset("MultiTransformer")]
    public class UMultiTransformer : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}