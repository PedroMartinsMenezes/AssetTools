namespace AssetTool
{
    [JsonAsset("IKRigAnimInstance")]
    public class UIKRigAnimInstance : UAnimPreviewInstance
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}