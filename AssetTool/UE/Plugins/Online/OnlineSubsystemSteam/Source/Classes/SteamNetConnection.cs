namespace AssetTool
{
    [JsonAsset("SteamNetConnection")]
    public class USteamNetConnection : UIpConnection
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}