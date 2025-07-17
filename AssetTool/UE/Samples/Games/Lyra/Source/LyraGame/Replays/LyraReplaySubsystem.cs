namespace AssetTool
{
    [JsonAsset("LyraReplayListEntry")]
    public class ULyraReplayListEntry : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LyraReplayList")]
    public class ULyraReplayList : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LyraReplaySubsystem")]
    public class ULyraReplaySubsystem : UGameInstanceSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}