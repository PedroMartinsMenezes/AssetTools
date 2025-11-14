namespace AssetTool
{
    [JsonAsset("ReplayTracksCameraModifier")]
    public class UReplayTracksCameraModifier : UCameraModifier
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}