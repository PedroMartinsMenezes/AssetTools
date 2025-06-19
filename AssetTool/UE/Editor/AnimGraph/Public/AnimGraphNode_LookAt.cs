namespace AssetTool
{
    [JsonAsset("AnimGraphNode_LookAt")]
    public class UAnimGraphNode_LookAt : UAnimGraphNode_SkeletalControlBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}