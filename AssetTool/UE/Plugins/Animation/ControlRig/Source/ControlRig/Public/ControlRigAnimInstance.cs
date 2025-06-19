namespace AssetTool
{
    [JsonAsset("ControlRigAnimInstance")]
    public class UControlRigAnimInstance : UAnimInstance
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}