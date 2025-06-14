namespace AssetTool
{
    [JsonAsset("DynamicMeshComponent")]
    public class UDynamicMeshComponent : UBaseDynamicMeshComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}