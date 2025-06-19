namespace AssetTool
{
    [JsonAsset("AvaShapeSphereDynamicMesh")]
    public class UAvaShapeSphereDynamicMesh : UAvaShape3DDynMeshBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}