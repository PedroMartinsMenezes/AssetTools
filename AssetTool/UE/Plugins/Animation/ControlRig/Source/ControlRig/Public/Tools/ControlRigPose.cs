namespace AssetTool
{
    [JsonAsset("ControlRigPoseAsset")]
    public class UControlRigPoseAsset : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}