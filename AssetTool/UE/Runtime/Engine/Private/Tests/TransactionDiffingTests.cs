namespace AssetTool
{
    [JsonAsset("TransactionDiffingTestObject")]
    public class UTransactionDiffingTestObject : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}