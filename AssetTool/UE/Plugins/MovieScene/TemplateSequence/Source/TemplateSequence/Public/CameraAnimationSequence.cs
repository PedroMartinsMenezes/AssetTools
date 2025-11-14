namespace AssetTool
{
    [JsonAsset("CameraAnimationSequence")]
    public class UCameraAnimationSequence : UTemplateSequence
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}