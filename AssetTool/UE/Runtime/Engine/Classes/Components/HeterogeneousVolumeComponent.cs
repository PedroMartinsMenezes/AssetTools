namespace AssetTool
{
    [JsonAsset("HeterogeneousVolumeComponent")]
    public class UHeterogeneousVolumeComponent : UMeshComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}