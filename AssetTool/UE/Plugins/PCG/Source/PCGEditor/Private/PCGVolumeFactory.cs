namespace AssetTool
{
    [JsonAsset("PCGVolumeFactory")]
    public class UPCGVolumeFactory : UActorFactoryBoxVolume
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}