namespace AssetTool
{
    [JsonAsset("LyraPlayerController")]
    public class ALyraPlayerController : ACommonPlayerController
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LyraReplayPlayerController")]
    public class ALyraReplayPlayerController : ALyraPlayerController
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}