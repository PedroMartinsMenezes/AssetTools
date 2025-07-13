namespace AssetTool
{
    [JsonAsset("SteamSocketsNetConnection")]
    public class USteamSocketsNetConnection : UNetConnection
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}