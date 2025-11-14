namespace AssetTool
{
    [JsonAsset("VolumeComponentToolTarget")]
    public class UVolumeComponentToolTarget : UPrimitiveComponentToolTarget
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("VolumeComponentToolTargetFactory")]
    public class UVolumeComponentToolTargetFactory : UToolTargetFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}