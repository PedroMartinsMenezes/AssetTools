using System.ComponentModel;

namespace AssetTool
{
    [Description("void UEdGraphNode::Serialize(FArchive& Ar)")]
    public class UEdGraphNode : UObject
    {
        [Sized] public List<UEdGraphPin> Pins;

        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);

            if (GlobalObjects.CustomVer(FBlueprintsObjectVersion.Guid) >= (int)FBlueprintsObjectVersion.Enums.EdGraphPinOptimized)
            {
                Pins ??= [];
                Pins.Resize(transfer);
                Pins.ForEach(x => x.MovePart1(transfer, UEdGraphPin.EPinResolveType.OwningNode));
            }
            return this;
        }
    }
}
