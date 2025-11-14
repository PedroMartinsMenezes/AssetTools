namespace AssetTool
{
    [JsonAsset("ControlRigAnimInstance")]
    public class UControlRigAnimInstance : UAnimInstance
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}