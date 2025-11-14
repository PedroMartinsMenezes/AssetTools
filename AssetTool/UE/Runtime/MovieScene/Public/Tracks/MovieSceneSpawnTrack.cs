namespace AssetTool
{
    [JsonAsset("MovieSceneSpawnTrack")]
    public class UMovieSceneSpawnTrack : UMovieSceneTrack
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}