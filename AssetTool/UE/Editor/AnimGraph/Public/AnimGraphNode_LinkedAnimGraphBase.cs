namespace AssetTool
{
    [JsonAsset("AnimGraphNode_LinkedAnimGraphBase")]
    public class UAnimGraphNode_LinkedAnimGraphBase : UAnimGraphNode_CustomProperty
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}