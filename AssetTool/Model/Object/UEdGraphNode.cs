namespace AssetTool
{

    [JsonAsset("EdGraphNode")]
    public class UEdGraphNode : UObject
    {
        public List<UEdGraphPin> Pins;

        [Location("void UEdGraphNode::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);

            if (Supports.EdGraphPinOptimized)
            {
                SerializeAsOwningNode(transfer);
            }
            return this;
        }

        [Location("void UEdGraphPin::SerializeAsOwningNode(FArchive& Ar, TArray<UEdGraphPin*>& ArrayRef)")]
        private void SerializeAsOwningNode(Transfer transfer)
        {
            UEdGraphPin.SerializePinArray(transfer, ref Pins, null, UEdGraphPin.EPinResolveType.OwningNode);
        }
    }
}
