namespace AssetTool
{
    [JsonAsset("MovieSceneTrackRecorderSettings")]
    public class UMovieSceneTrackRecorderSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}