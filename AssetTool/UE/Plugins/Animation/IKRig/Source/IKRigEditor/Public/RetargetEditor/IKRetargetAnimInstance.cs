namespace AssetTool
{
    [JsonAsset("IKRetargetAnimInstance")]
    public class UIKRetargetAnimInstance : UAnimPreviewInstance
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}