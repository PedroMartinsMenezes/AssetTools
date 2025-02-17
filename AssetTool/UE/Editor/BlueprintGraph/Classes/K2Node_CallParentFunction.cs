namespace AssetTool
{
    [JsonAsset("K2Node_CallParentFunction")]
    public class UK2Node_CallParentFunction : UK2Node_CallFunction
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}