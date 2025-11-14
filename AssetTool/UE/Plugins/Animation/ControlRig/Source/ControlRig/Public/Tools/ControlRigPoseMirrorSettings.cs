namespace AssetTool
{
    [JsonAsset("ControlRigPoseMirrorSettings")]
    public class UControlRigPoseMirrorSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}