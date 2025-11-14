namespace AssetTool
{
    [JsonAsset("MetasoundEditorGraphCommentNode")]
    public class UMetasoundEditorGraphCommentNode : UEdGraphNode_Comment
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}