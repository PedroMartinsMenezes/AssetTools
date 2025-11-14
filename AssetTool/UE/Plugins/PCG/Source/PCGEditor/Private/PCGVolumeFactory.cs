namespace AssetTool
{
    [JsonAsset("PCGVolumeFactory")]
    public class UPCGVolumeFactory : UActorFactoryBoxVolume
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}