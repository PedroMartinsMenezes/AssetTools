namespace AssetTool
{
    [JsonAsset("AvaShapeRingDynamicMesh")]
    public class UAvaShapeRingDynamicMesh : UAvaShape2DDynMeshBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}