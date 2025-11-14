namespace AssetTool
{
    [JsonAsset("AvaShapeRoundedPolygonDynamicMesh")]
    public class UAvaShapeRoundedPolygonDynamicMesh : UAvaShape2DDynMeshBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}