namespace AssetTool
{
    [JsonAsset("AnimStateTransitionNode")]
    public class UAnimStateTransitionNode : UAnimStateNodeBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}