namespace AssetTool
{
    [JsonAsset("PCGVolumeFactory")]
    public class UPCGVolumeFactory : UActorFactoryBoxVolume
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}