namespace AssetTool
{
    [JsonAsset("TwitterIntegrationBase")]
    public class UTwitterIntegrationBase : UPlatformInterfaceBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}