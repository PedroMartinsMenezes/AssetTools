namespace AssetTool
{
    [JsonAsset("MetasoundEditorGraphMemberDefaultLiteral")]
    public class UMetasoundEditorGraphMemberDefaultLiteral : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetasoundEditorGraphMember")]
    public class UMetasoundEditorGraphMember : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetasoundEditorGraphVertex")]
    public class UMetasoundEditorGraphVertex : UMetasoundEditorGraphMember
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetasoundEditorGraphInput")]
    public class UMetasoundEditorGraphInput : UMetasoundEditorGraphVertex
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetasoundEditorGraphOutput")]
    public class UMetasoundEditorGraphOutput : UMetasoundEditorGraphVertex
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetasoundEditorGraphVariable")]
    public class UMetasoundEditorGraphVariable : UMetasoundEditorGraphMember
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetasoundEditorGraph")]
    public class UMetasoundEditorGraph : UMetasoundEditorGraphBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}