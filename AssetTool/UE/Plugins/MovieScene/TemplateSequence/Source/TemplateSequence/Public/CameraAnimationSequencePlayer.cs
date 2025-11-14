namespace AssetTool
{
    [JsonAsset("CameraAnimationSequenceCameraStandIn")]
    public class UCameraAnimationSequenceCameraStandIn : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CameraAnimationSequencePlayer")]
    public class UCameraAnimationSequencePlayer : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}