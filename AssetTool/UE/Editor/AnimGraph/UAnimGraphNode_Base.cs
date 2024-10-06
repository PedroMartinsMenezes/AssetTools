namespace AssetTool
{
    [JsonAsset("AnimGraphNode_Base")]
    public class UAnimGraphNode_Base : UK2Node
    {
        [Location("void UAnimGraphNode_Base::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }
    }
}