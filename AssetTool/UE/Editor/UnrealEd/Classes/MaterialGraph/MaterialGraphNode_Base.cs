namespace AssetTool
{
    [JsonAsset("MaterialGraphNode_Base")]
    public class UMaterialGraphNode_Base : UEdGraphNode
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}