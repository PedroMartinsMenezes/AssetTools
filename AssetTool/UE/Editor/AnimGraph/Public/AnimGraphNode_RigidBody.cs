namespace AssetTool
{
    [JsonAsset("AnimGraphNode_RigidBody")]
    public class UAnimGraphNode_RigidBody : UAnimGraphNode_SkeletalControlBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}