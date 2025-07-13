namespace AssetTool
{
    [JsonAsset("MetasoundEditorGraphCommentNode")]
    public class UMetasoundEditorGraphCommentNode : UEdGraphNode_Comment
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}