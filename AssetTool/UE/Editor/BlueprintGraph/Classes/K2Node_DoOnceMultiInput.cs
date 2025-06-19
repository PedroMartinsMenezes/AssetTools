namespace AssetTool
{
    [JsonAsset("K2Node_DoOnceMultiInput")]
    public class UK2Node_DoOnceMultiInput : UK2Node
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}