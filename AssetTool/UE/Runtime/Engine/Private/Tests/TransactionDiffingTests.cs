namespace AssetTool
{
    [JsonAsset("TransactionDiffingTestObject")]
    public class UTransactionDiffingTestObject : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}