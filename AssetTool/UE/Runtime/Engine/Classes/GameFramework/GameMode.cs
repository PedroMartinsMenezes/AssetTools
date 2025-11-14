namespace AssetTool
{
    [JsonAsset("GameMode")]
    public class AGameMode : AGameModeBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}