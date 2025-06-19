namespace AssetTool
{
    [JsonAsset("PCGEditorGraphNode")]
    public class UPCGEditorGraphNode : UPCGEditorGraphNodeBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}