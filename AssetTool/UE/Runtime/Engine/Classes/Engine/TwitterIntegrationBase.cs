namespace AssetTool
{
    [JsonAsset("TwitterIntegrationBase")]
    public class UTwitterIntegrationBase : UPlatformInterfaceBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}