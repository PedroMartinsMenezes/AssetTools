namespace AssetTool
{
    [JsonAsset("AvaShapeStarDynamicMesh")]
    public class UAvaShapeStarDynamicMesh : UAvaShapeRoundedPolygonDynamicMesh
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}