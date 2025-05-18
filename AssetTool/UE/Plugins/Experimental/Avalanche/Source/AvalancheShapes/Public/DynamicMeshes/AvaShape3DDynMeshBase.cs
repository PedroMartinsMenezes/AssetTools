namespace AssetTool
{
    [JsonAsset("AvaShape3DDynMeshBase")]
    public class UAvaShape3DDynMeshBase : UAvaShapeDynamicMeshBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}