namespace AssetTool
{
    [JsonAsset("BaseDynamicMeshComponent")]
    public class UBaseDynamicMeshComponent : UMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}