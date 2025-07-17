namespace AssetTool
{
    [JsonAsset("LyraGameMode")]
    public class ALyraGameMode : AModularGameModeBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}