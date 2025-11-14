namespace AssetTool
{
    [JsonAsset("MediaCompositingTrackFilter")]
    public class UMediaCompositingTrackFilter : USequencerTrackFilterExtension
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}