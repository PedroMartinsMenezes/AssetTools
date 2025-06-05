namespace AssetTool
{
    [JsonAsset("AvaShapeLineDynamicMesh")]
    public class UAvaShapeLineDynamicMesh : UAvaShapeRoundedPolygonDynamicMesh
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}