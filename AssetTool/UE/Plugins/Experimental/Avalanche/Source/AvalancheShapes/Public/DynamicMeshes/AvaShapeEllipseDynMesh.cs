namespace AssetTool
{
    [JsonAsset("AvaShapeEllipseDynamicMesh")]
    public class UAvaShapeEllipseDynamicMesh : UAvaShape2DDynMeshBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}