namespace AssetTool
{
    [JsonAsset("K2Node_FunctionResult")]
    public class UK2Node_FunctionResult : UK2Node_FunctionTerminator
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}