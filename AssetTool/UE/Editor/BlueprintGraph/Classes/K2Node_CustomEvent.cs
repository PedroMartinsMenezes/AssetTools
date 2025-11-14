namespace AssetTool
{
    [JsonAsset("K2Node_CustomEvent")]
    public class UK2Node_CustomEvent : UK2Node_Event
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}