namespace AssetTool
{
    [JsonAsset("AnimGraphNode_OverrideRootMotion")]
    public class UAnimGraphNode_OverrideRootMotion : UAnimGraphNode_Base
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}