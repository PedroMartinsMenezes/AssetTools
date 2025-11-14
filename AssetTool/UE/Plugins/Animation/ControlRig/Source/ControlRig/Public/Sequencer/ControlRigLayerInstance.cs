namespace AssetTool
{
    [JsonAsset("ControlRigLayerInstance")]
    public class UControlRigLayerInstance : UAnimInstance
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}