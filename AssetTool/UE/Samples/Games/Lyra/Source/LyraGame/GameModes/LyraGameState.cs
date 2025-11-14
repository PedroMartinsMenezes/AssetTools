namespace AssetTool
{
    [JsonAsset("LyraGameState")]
    public class ALyraGameState : AModularGameStateBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}