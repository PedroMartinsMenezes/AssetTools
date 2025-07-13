namespace AssetTool
{
    [JsonAsset("CameraAnimationSequence")]
    public class UCameraAnimationSequence : UTemplateSequence
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}