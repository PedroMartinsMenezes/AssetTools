namespace AssetTool
{
    [JsonAsset("SteamClient")]
    public class USteamClient : UIPClient
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}