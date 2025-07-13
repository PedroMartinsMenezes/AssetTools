namespace AssetTool
{
    [JsonAsset("OctreeDynamicMeshComponent")]
    public class UOctreeDynamicMeshComponent : UBaseDynamicMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}