namespace AssetTool
{
    [JsonAsset("AvaShapeCubeDynamicMesh")]
    public class UAvaShapeCubeDynamicMesh : UAvaShape3DDynMeshBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}