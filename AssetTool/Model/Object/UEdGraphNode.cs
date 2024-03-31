using System.ComponentModel;

namespace AssetTool
{
    [Description("void UEdGraphNode::Serialize(FArchive& Ar)")]
    public class UEdGraphNode : UObject
    {
        [Sized] public List<UEdGraphPin> Pins;

        public UEdGraphNode Read(BinaryReader reader)
        {
            base.Read(reader);
            if (GlobalObjects.CustomVer(FBlueprintsObjectVersion.Guid) >= (int)FBlueprintsObjectVersion.Enums.EdGraphPinOptimized)
            {
                Pins = [];
                Pins.Resize(reader.ReadInt32());
                Pins.ForEach(x => x.ReadPart1(reader, UEdGraphPin.EPinResolveType.OwningNode));
            }
            return this;
        }
        public new void Write(BinaryWriter writer)
        {
            base.Write(writer);
            if (GlobalObjects.CustomVer(FBlueprintsObjectVersion.Guid) >= (int)FBlueprintsObjectVersion.Enums.EdGraphPinOptimized)
            {
                writer.Write(Pins.Count);
                Pins.ForEach(x => x.WritePart1(writer, UEdGraphPin.EPinResolveType.OwningNode));
            }
        }
    }
}
