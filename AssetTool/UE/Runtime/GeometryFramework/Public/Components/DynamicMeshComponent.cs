namespace AssetTool
{
    [JsonAsset("DynamicMeshComponent")]
    public class UDynamicMeshComponent : UBaseDynamicMeshComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}