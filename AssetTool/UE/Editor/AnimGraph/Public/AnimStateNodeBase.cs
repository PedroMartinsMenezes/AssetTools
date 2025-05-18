namespace AssetTool
{
    [JsonAsset("AnimStateNodeBase")]
    public class UAnimStateNodeBase : UEdGraphNode
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}