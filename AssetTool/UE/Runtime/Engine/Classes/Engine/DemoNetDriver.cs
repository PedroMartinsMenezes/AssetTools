namespace AssetTool
{
    [JsonAsset("DemoNetDriver")]
    public class UDemoNetDriver : UNetDriver
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}