namespace AssetTool
{
    [JsonAsset("AnimStateTransitionNode")]
    public class UAnimStateTransitionNode : UAnimStateNodeBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}