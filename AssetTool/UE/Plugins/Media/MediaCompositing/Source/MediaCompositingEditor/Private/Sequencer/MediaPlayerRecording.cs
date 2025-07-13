namespace AssetTool
{
    [JsonAsset("MediaPlayerRecording")]
    public class UMediaPlayerRecording : USequenceRecordingBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}