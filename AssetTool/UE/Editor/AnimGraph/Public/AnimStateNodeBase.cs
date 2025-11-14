namespace AssetTool
{
    [JsonAsset("AnimStateNodeBase")]
    public class UAnimStateNodeBase : UEdGraphNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}