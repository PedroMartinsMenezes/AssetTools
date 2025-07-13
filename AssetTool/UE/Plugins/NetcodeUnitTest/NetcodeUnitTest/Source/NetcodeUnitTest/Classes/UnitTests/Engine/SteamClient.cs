namespace AssetTool
{
    [JsonAsset("SteamClient")]
    public class USteamClient : UIPClient
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}