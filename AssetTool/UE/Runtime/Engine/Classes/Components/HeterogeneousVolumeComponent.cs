namespace AssetTool
{
    [JsonAsset("HeterogeneousVolumeComponent")]
    public class UHeterogeneousVolumeComponent : UMeshComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}