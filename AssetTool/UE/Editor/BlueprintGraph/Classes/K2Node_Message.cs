namespace AssetTool
{
    [JsonAsset("K2Node_Message")]
    public class UK2Node_Message : UK2Node_CallFunction
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}