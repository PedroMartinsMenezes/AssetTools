namespace AssetTool
{
    [JsonAsset("AvaShapeNGonDynamicMesh")]
    public class UAvaShapeNGonDynamicMesh : UAvaShapeRoundedPolygonDynamicMesh
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}