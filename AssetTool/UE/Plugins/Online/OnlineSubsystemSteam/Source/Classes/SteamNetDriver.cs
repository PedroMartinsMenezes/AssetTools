namespace AssetTool
{
    [JsonAsset("SteamNetDriver")]
    public class USteamNetDriver : UIpNetDriver
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}