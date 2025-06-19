namespace AssetTool
{
    [JsonAsset("DemoNetDriver")]
    public class UDemoNetDriver : UNetDriver
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}