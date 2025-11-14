namespace AssetTool
{
    [JsonAsset("SteamSocketsNetConnection")]
    public class USteamSocketsNetConnection : UNetConnection
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}