namespace AssetTool
{
    [JsonAsset("ControlRigLayerInstance")]
    public class UControlRigLayerInstance : UAnimInstance
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}