namespace AssetTool
{
    [JsonAsset("K2Node_AssignDelegate")]
    public class UK2Node_AssignDelegate : UK2Node_AddDelegate
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}