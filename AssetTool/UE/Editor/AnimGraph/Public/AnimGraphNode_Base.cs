namespace AssetTool
{
    [JsonAsset("AnimGraphNode_Base")]
    public class UAnimGraphNode_Base : UK2Node
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}