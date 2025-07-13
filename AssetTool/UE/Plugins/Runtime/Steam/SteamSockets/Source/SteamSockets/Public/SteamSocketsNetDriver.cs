namespace AssetTool
{
    [JsonAsset("SteamSocketsNetDriver")]
    public class USteamSocketsNetDriver : UNetDriver
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}