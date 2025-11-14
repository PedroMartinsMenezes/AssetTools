namespace AssetTool
{
    [JsonAsset("AnimGraphNode_LookAt")]
    public class UAnimGraphNode_LookAt : UAnimGraphNode_SkeletalControlBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}