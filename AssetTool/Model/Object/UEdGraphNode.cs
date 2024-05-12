using System.ComponentModel;

namespace AssetTool
{
    [Description("void UEdGraphNode::Serialize(FArchive& Ar)")]
    public class UEdGraphNode : UObject
    {
        [Sized] public List<UEdGraphPin> Pins;

        public UEdGraphNode Read(BinaryReader reader)
        {
            base.Move(GlobalObjects.Transfer);
            if (GlobalObjects.CustomVer(FBlueprintsObjectVersion.Guid) >= (int)FBlueprintsObjectVersion.Enums.EdGraphPinOptimized)
            {
                Pins = [];
                Pins.Resize(reader.ReadInt32());
                Pins.ForEach(x => x.ReadPart1(reader, UEdGraphPin.EPinResolveType.OwningNode));
            }
            return this;
        }
        public void Write(BinaryWriter writer)
        {
            base.Move(GlobalObjects.Transfer);
            if (GlobalObjects.CustomVer(FBlueprintsObjectVersion.Guid) >= (int)FBlueprintsObjectVersion.Enums.EdGraphPinOptimized)
            {
                writer.Write(Pins.Count);
                Pins.ForEach(x => x.WritePart1(writer, UEdGraphPin.EPinResolveType.OwningNode));
            }
        }
    }
}
