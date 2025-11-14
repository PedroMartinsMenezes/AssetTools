namespace AssetTool
{
    [JsonAsset("MovieSceneTrackRecorderSettings")]
    public class UMovieSceneTrackRecorderSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}