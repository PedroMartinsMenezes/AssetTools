namespace AssetTool
{
    [JsonAsset("AvaShapeLineDynamicMesh")]
    public class UAvaShapeLineDynamicMesh : UAvaShapeRoundedPolygonDynamicMesh
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}