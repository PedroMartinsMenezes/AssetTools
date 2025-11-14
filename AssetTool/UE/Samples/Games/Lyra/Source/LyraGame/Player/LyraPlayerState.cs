namespace AssetTool
{
    [JsonAsset("LyraPlayerState")]
    public class ALyraPlayerState : AModularPlayerState
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}