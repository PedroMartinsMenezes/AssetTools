namespace AssetTool
{
    [JsonAsset("AvaShapeStarDynamicMesh")]
    public class UAvaShapeStarDynamicMesh : UAvaShapeRoundedPolygonDynamicMesh
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}