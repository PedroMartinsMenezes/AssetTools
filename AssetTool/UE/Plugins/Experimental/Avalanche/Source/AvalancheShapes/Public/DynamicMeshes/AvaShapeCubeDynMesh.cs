namespace AssetTool
{
    [JsonAsset("AvaShapeCubeDynamicMesh")]
    public class UAvaShapeCubeDynamicMesh : UAvaShape3DDynMeshBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}