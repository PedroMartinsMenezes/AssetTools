namespace AssetTool
{
    [JsonAsset("AnimationRecordingParameters")]
    public class UAnimationRecordingParameters : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}