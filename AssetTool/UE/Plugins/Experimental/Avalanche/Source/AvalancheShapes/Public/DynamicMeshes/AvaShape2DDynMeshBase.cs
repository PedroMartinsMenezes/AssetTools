namespace AssetTool
{
    [JsonAsset("AvaShape2DDynMeshBase")]
    public class UAvaShape2DDynMeshBase : UAvaShapeDynamicMeshBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}