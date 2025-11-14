namespace AssetTool
{
    [JsonAsset("SteamNetConnection")]
    public class USteamNetConnection : UIpConnection
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}