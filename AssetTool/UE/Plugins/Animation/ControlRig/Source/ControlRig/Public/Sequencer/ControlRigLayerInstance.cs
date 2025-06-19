namespace AssetTool
{
    [JsonAsset("ControlRigLayerInstance")]
    public class UControlRigLayerInstance : UAnimInstance
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}