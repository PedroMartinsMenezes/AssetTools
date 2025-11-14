namespace AssetTool
{
    [JsonAsset("ViewportTransformer")]
    public class UViewportTransformer : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}