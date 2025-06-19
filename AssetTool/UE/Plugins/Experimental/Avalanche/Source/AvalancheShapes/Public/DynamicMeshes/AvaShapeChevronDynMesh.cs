namespace AssetTool
{
    [JsonAsset("AvaShapeChevronDynamicMesh")]
    public class UAvaShapeChevronDynamicMesh : UAvaShape2DDynMeshBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}