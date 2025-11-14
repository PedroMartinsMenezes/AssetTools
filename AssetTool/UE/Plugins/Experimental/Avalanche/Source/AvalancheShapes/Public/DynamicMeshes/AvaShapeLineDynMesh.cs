namespace AssetTool
{
    [JsonAsset("AvaShapeLineDynamicMesh")]
    public class UAvaShapeLineDynamicMesh : UAvaShapeRoundedPolygonDynamicMesh
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}