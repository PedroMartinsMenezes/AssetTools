namespace AssetTool
{
    [JsonAsset("MovieSceneSpawnTrack")]
    public class UMovieSceneSpawnTrack : UMovieSceneTrack
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}