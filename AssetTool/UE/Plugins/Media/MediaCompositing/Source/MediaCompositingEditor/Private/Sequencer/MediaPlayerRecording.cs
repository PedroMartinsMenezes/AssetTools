namespace AssetTool
{
    [JsonAsset("MediaPlayerRecording")]
    public class UMediaPlayerRecording : USequenceRecordingBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}