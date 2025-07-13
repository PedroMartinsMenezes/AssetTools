namespace AssetTool
{
    [JsonAsset("LobbyBeaconState")]
    public class ALobbyBeaconState : AInfo
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}