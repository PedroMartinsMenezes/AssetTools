namespace AssetTool
{
    [JsonAsset("ViewportTransformer")]
    public class UViewportTransformer : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}