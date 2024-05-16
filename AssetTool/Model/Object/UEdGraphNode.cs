using System.ComponentModel;

namespace AssetTool
{
    [Description("void UEdGraphNode::Serialize(FArchive& Ar)")]
    public class UEdGraphNode : UObject
    {
        [Sized] public List<UEdGraphPin> Pins;

        public new UEdGraphNode Move(Transfer transfer)
        {
            base.Move(transfer);
            if (transfer.IsReading)
                return Read(transfer.reader);
            else
                return Write(transfer.writer);
        }

        private UEdGraphNode Read(BinaryReader reader)
        {
            if (GlobalObjects.CustomVer(FBlueprintsObjectVersion.Guid) >= (int)FBlueprintsObjectVersion.Enums.EdGraphPinOptimized)
            {
                Pins = [];
                Pins.Resize(reader.ReadInt32());
                Pins.ForEach(x => x.MovePart1(GlobalObjects.Transfer, UEdGraphPin.EPinResolveType.OwningNode));
            }
            return this;
        }

        private UEdGraphNode Write(BinaryWriter writer)
        {
            if (GlobalObjects.CustomVer(FBlueprintsObjectVersion.Guid) >= (int)FBlueprintsObjectVersion.Enums.EdGraphPinOptimized)
            {
                writer.Write(Pins.Count);
                Pins.ForEach(x => x.MovePart1(GlobalObjects.Transfer, UEdGraphPin.EPinResolveType.OwningNode));
            }
            return this;
        }
    }
}
