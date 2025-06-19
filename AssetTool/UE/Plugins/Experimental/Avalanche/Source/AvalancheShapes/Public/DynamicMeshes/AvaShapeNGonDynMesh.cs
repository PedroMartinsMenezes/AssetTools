namespace AssetTool
{
    [JsonAsset("AvaShapeNGonDynamicMesh")]
    public class UAvaShapeNGonDynamicMesh : UAvaShapeRoundedPolygonDynamicMesh
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}