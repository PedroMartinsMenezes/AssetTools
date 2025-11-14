namespace AssetTool
{
    [JsonAsset("PCGEditorGraphNodeReroute")]
    public class UPCGEditorGraphNodeReroute : UPCGEditorGraphNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGEditorGraphNodeNamedRerouteBase")]
    public class UPCGEditorGraphNodeNamedRerouteBase : UPCGEditorGraphNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGEditorGraphNodeNamedRerouteUsage")]
    public class UPCGEditorGraphNodeNamedRerouteUsage : UPCGEditorGraphNodeNamedRerouteBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGEditorGraphNodeNamedRerouteDeclaration")]
    public class UPCGEditorGraphNodeNamedRerouteDeclaration : UPCGEditorGraphNodeNamedRerouteBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}