namespace AssetTool
{
    [JsonAsset("AvaShape3DDynMeshBase")]
    public class UAvaShape3DDynMeshBase : UAvaShapeDynamicMeshBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}