namespace AssetTool
{
    [JsonAsset("LyraPlayerController")]
    public class ALyraPlayerController : ACommonPlayerController
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LyraReplayPlayerController")]
    public class ALyraReplayPlayerController : ALyraPlayerController
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}