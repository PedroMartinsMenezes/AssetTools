namespace AssetTool
{
    [JsonAsset("LyraGameState")]
    public class ALyraGameState : AModularGameStateBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}