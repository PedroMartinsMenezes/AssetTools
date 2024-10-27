namespace AssetTool
{
    [JsonAsset("ControlRigAnimInstance")]
    public class  UControlRigAnimInstance : UAnimInstance
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}