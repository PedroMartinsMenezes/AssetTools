namespace AssetTool
{
    [JsonAsset("AvaShapeConeDynamicMesh")]
    public class UAvaShapeConeDynamicMesh : UAvaShape3DDynMeshBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}