namespace AssetTool
{
    [JsonAsset("AvaShapeCubeDynamicMesh")]
    public class UAvaShapeCubeDynamicMesh : UAvaShape3DDynMeshBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}