namespace AssetTool
{
    [JsonAsset("HeterogeneousVolumeComponent")]
    public class UHeterogeneousVolumeComponent : UMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}