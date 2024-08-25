namespace AssetTool
{
    [Location("void UAnimGraphNode_Base::Serialize(FArchive& Ar)")]
    public class UAnimGraphNode_Base : UK2Node
    {
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }
    }
}