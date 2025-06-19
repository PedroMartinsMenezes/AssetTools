namespace AssetTool
{
    [JsonAsset("AvaShapeRectangleDynamicMesh")]
    public class UAvaShapeRectangleDynamicMesh : UAvaShape2DDynMeshBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}