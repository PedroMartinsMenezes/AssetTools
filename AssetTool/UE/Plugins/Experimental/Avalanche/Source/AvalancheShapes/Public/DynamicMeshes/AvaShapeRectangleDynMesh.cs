namespace AssetTool
{
    [JsonAsset("AvaShapeRectangleDynamicMesh")]
    public class UAvaShapeRectangleDynamicMesh : UAvaShape2DDynMeshBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}