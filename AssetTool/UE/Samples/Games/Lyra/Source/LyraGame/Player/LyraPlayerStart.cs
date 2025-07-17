namespace AssetTool
{
    [JsonAsset("LyraPlayerStart")]
    public class ALyraPlayerStart : APlayerStart
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}