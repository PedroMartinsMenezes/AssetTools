namespace AssetTool
{
    [JsonAsset("GraphNodeContextMenuContext")]
    public class UGraphNodeContextMenuContext : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("EdGraphNode")]
    public class UEdGraphNode : UObject
    {
        public List<UEdGraphPin> Pins;

        [Location("void UEdGraphNode::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
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
            UEdGraphPin.SerializePinArray(transfer, ref Pins, default, UEdGraphPin.EPinResolveType.OwningNode);
        }
    }
}