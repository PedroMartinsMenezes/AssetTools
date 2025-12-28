namespace AssetTool
{
    [JsonAsset("EdGraphNode")]
    public class UEdGraphNode : UObject
    {
        public List<EdGraphPin> Pins;

        [Location("void UEdGraphNode::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);

            if (transfer.Supports.EdGraphPinOptimized)
            {
                SerializeAsOwningNode(transfer);
            }
            return this;
        }

        [Location("void UEdGraphPin::SerializeAsOwningNode(FArchive& Ar, TArray<UEdGraphPin*>& ArrayRef)")]
        private void SerializeAsOwningNode(Transfer transfer)
        {
            EdGraphPin.SerializePinArray(transfer, ref Pins, EPinResolveType.OwningNode, this);
        }
    }

    public enum EEdGraphPinDirection : byte
    {
        EGPD_Input,
        EGPD_Output,
        EGPD_MAX
    }
}