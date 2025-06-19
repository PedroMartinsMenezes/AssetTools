namespace AssetTool
{
    [JsonAsset("AvaShape2DDynMeshBase")]
    public class UAvaShape2DDynMeshBase : UAvaShapeDynamicMeshBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}