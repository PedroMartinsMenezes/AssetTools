namespace AssetTool
{
    [JsonAsset("MetasoundEditorGraphMemberDefaultLiteral")]
    public class UMetasoundEditorGraphMemberDefaultLiteral : UMetaSoundFrontendMemberMetadata
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetasoundEditorGraphMember")]
    public class UMetasoundEditorGraphMember : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetasoundEditorGraphVertex")]
    public class UMetasoundEditorGraphVertex : UMetasoundEditorGraphMember
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetasoundEditorGraphInput")]
    public class UMetasoundEditorGraphInput : UMetasoundEditorGraphVertex
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetasoundEditorGraphOutput")]
    public class UMetasoundEditorGraphOutput : UMetasoundEditorGraphVertex
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetasoundEditorGraphVariable")]
    public class UMetasoundEditorGraphVariable : UMetasoundEditorGraphMember
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetasoundEditorGraph")]
    public class UMetasoundEditorGraph : UMetasoundEditorGraphBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}