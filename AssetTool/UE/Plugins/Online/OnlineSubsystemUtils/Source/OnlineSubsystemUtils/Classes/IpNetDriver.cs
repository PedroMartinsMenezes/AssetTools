namespace AssetTool
{
    [JsonAsset("IpNetDriver")]
    public class UIpNetDriver : UNetDriver
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}