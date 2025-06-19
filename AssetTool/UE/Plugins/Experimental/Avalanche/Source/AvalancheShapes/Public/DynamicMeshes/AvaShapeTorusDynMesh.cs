namespace AssetTool
{
    [JsonAsset("AvaShapeTorusDynamicMesh")]
    public class UAvaShapeTorusDynamicMesh : UAvaShape3DDynMeshBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}