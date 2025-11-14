namespace AssetTool
{
    [JsonAsset("K2Node_GenericCreateObject")]
    public class UK2Node_GenericCreateObject : UK2Node_ConstructObjectFromClass
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}