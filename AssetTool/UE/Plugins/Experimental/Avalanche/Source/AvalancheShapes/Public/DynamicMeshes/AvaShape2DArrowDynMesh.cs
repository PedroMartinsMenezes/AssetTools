namespace AssetTool
{
    [JsonAsset("AvaShape2DArrowDynamicMesh")]
    public class UAvaShape2DArrowDynamicMesh : UAvaShape2DDynMeshBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}