namespace AssetTool
{
    [JsonAsset("GameMode")]
    public class AGameMode : AGameModeBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}