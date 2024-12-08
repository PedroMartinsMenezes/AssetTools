namespace AssetTool
{
    [JsonAsset("DemoNetDriver")]
    public class UDemoNetDriver : UNetDriver
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}