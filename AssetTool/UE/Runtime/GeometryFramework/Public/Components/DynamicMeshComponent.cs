namespace AssetTool
{
    [JsonAsset("DynamicMeshComponent")]
    public class UDynamicMeshComponent : UBaseDynamicMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}