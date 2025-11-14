namespace AssetTool
{
    [JsonAsset("LobbyBeaconState")]
    public class ALobbyBeaconState : AInfo
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}