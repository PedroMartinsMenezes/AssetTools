namespace AssetTool
{
    [JsonAsset("GameMode")]
    public class AGameMode : AGameModeBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}