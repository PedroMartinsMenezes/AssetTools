namespace AssetTool
{
    [Flags]
    public enum ECurveEditorTreeFilterState : uint8
    {
        NoMatch = 0x00,
        ImplicitChild = (1 << 0),
        ImplicitParent = (1 << 1),
        Match = (1 << 2),
        Expand = (1 << 3),
        MatchBitMask = (ImplicitParent | Match | ImplicitChild),
    };
}
