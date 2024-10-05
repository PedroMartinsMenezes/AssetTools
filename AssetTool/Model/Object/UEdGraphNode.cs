using System.ComponentModel;

namespace AssetTool
{
    [Description("void UEdGraphNode::Serialize(FArchive& Ar)")]
    [JsonAsset("EdGraphNode")]
    public class UEdGraphNode : UObject
    {
        [Sized] public List<UEdGraphPin> Pins;

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
