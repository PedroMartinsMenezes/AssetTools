namespace AssetTool
{
    [JsonAsset("K2Node_Self")]
    public class UK2Node_Self : UK2Node
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}