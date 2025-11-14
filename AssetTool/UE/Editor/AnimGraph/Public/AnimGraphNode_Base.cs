namespace AssetTool
{
    [JsonAsset("AnimGraphNode_Base")]
    public class UAnimGraphNode_Base : UK2Node
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}