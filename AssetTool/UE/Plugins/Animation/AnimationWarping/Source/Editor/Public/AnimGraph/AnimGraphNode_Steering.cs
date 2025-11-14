namespace AssetTool
{
    [JsonAsset("AnimGraphNode_Steering")]
    public class UAnimGraphNode_Steering : UAnimGraphNode_SkeletalControlBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}