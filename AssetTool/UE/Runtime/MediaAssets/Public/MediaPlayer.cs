namespace AssetTool
{
    [JsonAsset("MediaTimeStampInfo")]
    public class UMediaTimeStampInfo : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MediaPlayer")]
    public class UMediaPlayer : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}