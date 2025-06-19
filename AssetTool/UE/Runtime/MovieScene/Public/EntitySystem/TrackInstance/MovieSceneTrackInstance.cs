namespace AssetTool
{
    [JsonAsset("MovieSceneTrackInstance")]
    public class UMovieSceneTrackInstance : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}