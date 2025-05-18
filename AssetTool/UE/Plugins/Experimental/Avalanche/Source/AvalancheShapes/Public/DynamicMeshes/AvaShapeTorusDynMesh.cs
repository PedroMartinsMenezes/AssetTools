namespace AssetTool
{
    [JsonAsset("AvaShapeTorusDynamicMesh")]
    public class UAvaShapeTorusDynamicMesh : UAvaShape3DDynMeshBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}