namespace AssetTool
{
    [JsonAsset("AvaShapeSphereDynamicMesh")]
    public class UAvaShapeSphereDynamicMesh : UAvaShape3DDynMeshBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}