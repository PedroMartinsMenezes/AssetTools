namespace AssetTool
{
    [JsonAsset("AvaShape2DDynMeshBase")]
    public class UAvaShape2DDynMeshBase : UAvaShapeDynamicMeshBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}