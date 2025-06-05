namespace AssetTool
{
    [JsonAsset("AvaShapeConeDynamicMesh")]
    public class UAvaShapeConeDynamicMesh : UAvaShape3DDynMeshBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}