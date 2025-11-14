namespace AssetTool
{
    [JsonAsset("AnimGraphNode_BoneDrivenController")]
    public class UAnimGraphNode_BoneDrivenController : UAnimGraphNode_SkeletalControlBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}