namespace AssetTool
{
    [JsonAsset("AnimStateNodeBase")]
    public class UAnimStateNodeBase : UEdGraphNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}