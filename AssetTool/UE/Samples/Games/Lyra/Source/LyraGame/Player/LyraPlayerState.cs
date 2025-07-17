namespace AssetTool
{
    [JsonAsset("LyraPlayerState")]
    public class ALyraPlayerState : AModularPlayerState
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}