namespace AssetTool
{
    [JsonAsset("SteamSocketsNetDriver")]
    public class USteamSocketsNetDriver : UNetDriver
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}