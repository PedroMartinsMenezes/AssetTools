namespace AssetTool
{
    [JsonAsset("LyraPlayerStart")]
    public class ALyraPlayerStart : APlayerStart
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}