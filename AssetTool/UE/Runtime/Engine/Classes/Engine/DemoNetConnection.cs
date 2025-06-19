namespace AssetTool
{
    [JsonAsset("DemoNetConnection")]
    public class UDemoNetConnection : UNetConnection
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}