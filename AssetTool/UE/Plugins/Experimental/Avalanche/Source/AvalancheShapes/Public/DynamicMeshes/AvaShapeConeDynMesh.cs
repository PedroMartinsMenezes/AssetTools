namespace AssetTool
{
    [JsonAsset("AvaShapeConeDynamicMesh")]
    public class UAvaShapeConeDynamicMesh : UAvaShape3DDynMeshBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}