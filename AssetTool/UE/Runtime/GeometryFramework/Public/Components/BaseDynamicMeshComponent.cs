namespace AssetTool
{
    [JsonAsset("BaseDynamicMeshComponent")]
    public class UBaseDynamicMeshComponent : UMeshComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}