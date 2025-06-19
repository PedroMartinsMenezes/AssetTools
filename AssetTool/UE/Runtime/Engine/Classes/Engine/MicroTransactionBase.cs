namespace AssetTool
{
    [JsonAsset("MicroTransactionBase")]
    public class UMicroTransactionBase : UPlatformInterfaceBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}