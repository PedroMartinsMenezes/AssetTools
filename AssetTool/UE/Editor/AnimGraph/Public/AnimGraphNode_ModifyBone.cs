namespace AssetTool
{
    [JsonAsset("AnimGraphNode_ModifyBone")]
    public class UAnimGraphNode_ModifyBone : UAnimGraphNode_SkeletalControlBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}