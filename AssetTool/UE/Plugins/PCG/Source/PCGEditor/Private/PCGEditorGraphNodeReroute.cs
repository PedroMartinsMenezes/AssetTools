namespace AssetTool
{
    [JsonAsset("PCGEditorGraphNodeReroute")]
    public class UPCGEditorGraphNodeReroute : UPCGEditorGraphNode
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGEditorGraphNodeNamedRerouteBase")]
    public class UPCGEditorGraphNodeNamedRerouteBase : UPCGEditorGraphNode
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGEditorGraphNodeNamedRerouteUsage")]
    public class UPCGEditorGraphNodeNamedRerouteUsage : UPCGEditorGraphNodeNamedRerouteBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGEditorGraphNodeNamedRerouteDeclaration")]
    public class UPCGEditorGraphNodeNamedRerouteDeclaration : UPCGEditorGraphNodeNamedRerouteBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}