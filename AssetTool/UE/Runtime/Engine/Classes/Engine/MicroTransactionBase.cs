namespace AssetTool
{
    [JsonAsset("MicroTransactionBase")]
    public class UMicroTransactionBase : UPlatformInterfaceBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}