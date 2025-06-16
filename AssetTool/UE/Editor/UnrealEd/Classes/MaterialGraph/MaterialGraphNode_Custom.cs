namespace AssetTool
{
    [JsonAsset("MaterialGraphNode_Custom")]
    public class UMaterialGraphNode_Custom : UMaterialGraphNode
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}