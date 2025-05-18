namespace AssetTool
{
    [JsonAsset("AvaShapeNGonDynamicMesh")]
    public class UAvaShapeNGonDynamicMesh : UAvaShapeRoundedPolygonDynamicMesh
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}