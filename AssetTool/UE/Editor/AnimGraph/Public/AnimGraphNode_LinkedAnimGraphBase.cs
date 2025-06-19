namespace AssetTool
{
    [JsonAsset("AnimGraphNode_LinkedAnimGraphBase")]
    public class UAnimGraphNode_LinkedAnimGraphBase : UAnimGraphNode_CustomProperty
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}