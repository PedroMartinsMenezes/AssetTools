namespace AssetTool
{
    [JsonAsset("K2Node_LoadAsset")]
    public class UK2Node_LoadAsset : UK2Node
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("K2Node_LoadAssetClass")]
    public class UK2Node_LoadAssetClass : UK2Node_LoadAsset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}