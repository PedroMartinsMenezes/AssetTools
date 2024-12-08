namespace AssetTool
{
    [JsonAsset("DemoNetConnection")]
    public class UDemoNetConnection : UNetConnection
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}