namespace AssetTool
{
    [JsonAsset("BaseDynamicMeshComponent")]
    public class UBaseDynamicMeshComponent : UMeshComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}