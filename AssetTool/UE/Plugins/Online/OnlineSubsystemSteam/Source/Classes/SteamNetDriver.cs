namespace AssetTool
{
    [JsonAsset("SteamNetDriver")]
    public class USteamNetDriver : UIpNetDriver
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}