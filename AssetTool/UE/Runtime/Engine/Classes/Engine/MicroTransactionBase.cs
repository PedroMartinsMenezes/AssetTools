namespace AssetTool
{
    [JsonAsset("MicroTransactionBase")]
    public class UMicroTransactionBase : UPlatformInterfaceBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}