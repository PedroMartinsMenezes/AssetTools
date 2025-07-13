namespace AssetTool
{
    [JsonAsset("MediaCompositingTrackFilter")]
    public class UMediaCompositingTrackFilter : USequencerTrackFilterExtension
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}