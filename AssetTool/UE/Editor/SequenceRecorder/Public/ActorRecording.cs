namespace AssetTool
{
    [JsonAsset("ActorRecording")]
    public class UActorRecording : USequenceRecordingBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}