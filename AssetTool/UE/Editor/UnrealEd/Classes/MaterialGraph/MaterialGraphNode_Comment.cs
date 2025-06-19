namespace AssetTool
{
    [JsonAsset("MaterialGraphNode_Comment")]
    public class UMaterialGraphNode_Comment : UEdGraphNode_Comment
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}