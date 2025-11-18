
namespace AssetTool.Generator.CodeGen
{
    public class Pin
    {
        public string Id { get; }
        public Node Parent { get; set; }
        public EEdGraphPinDirection Direction { get; }
        public string PinCategory { get; }
        public List<Pin> LinkedTo { get; set; }
        public string MemberName { get; }

        public Pin() { }

        public Pin(UEdGraphPin other, Dictionary<string, UEdGraphPin> basePins)
        {
            Id = other.PinId.ToString();
            Direction = other.Direction;
            PinCategory = other.PinType?.PinCategory?.ValidValue;
            MemberName = other.PinType?.PinSubCategoryMemberReference?.MemberName?.ValidValue;
            PinCategory = other.PinType?.PinCategory?.Value;

            if (other.LinkedTo is { } && basePins is { })
            {
                LinkedTo = other.LinkedTo.List.Select(x => x.PinGuid.ToString()).Select(x => basePins[x]).Select(x => new Pin(x, null)).ToList();
            }
        }

        public bool IsExec()
        {
            return PinCategory == "exec" && LinkedTo.Any();
        }
    }
}
