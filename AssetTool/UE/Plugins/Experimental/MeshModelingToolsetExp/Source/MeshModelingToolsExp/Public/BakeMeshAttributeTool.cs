namespace AssetTool
{
    [JsonAsset("BakeMeshAttributeTool")]
    public class UBakeMeshAttributeTool : UMultiSelectionMeshEditingTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}