namespace AssetTool
{
    [JsonAsset("IKRigAnimInstance")]
    public class UIKRigAnimInstance : UAnimPreviewInstance
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}