namespace AssetTool
{
    [JsonAsset("MetasoundEditorGraphNode")]
    public class UMetasoundEditorGraphNode : UEdGraphNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetasoundEditorGraphMemberNode")]
    public class UMetasoundEditorGraphMemberNode : UMetasoundEditorGraphNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetasoundEditorGraphOutputNode")]
    public class UMetasoundEditorGraphOutputNode : UMetasoundEditorGraphMemberNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetasoundEditorGraphExternalNode")]
    public class UMetasoundEditorGraphExternalNode : UMetasoundEditorGraphNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetasoundEditorGraphVariableNode")]
    public class UMetasoundEditorGraphVariableNode : UMetasoundEditorGraphMemberNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}