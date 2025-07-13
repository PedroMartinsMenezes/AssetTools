namespace AssetTool
{
    [JsonAsset("MultiTransformer")]
    public class UMultiTransformer : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}