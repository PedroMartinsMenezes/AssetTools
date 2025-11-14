namespace AssetTool
{
    [JsonAsset("ActorRecording")]
    public class UActorRecording : USequenceRecordingBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}