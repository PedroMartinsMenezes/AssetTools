namespace AssetTool
{
    [JsonAsset("AvaShapeStarDynamicMesh")]
    public class UAvaShapeStarDynamicMesh : UAvaShapeRoundedPolygonDynamicMesh
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}