namespace AssetTool
{
    [JsonAsset("MovieSceneEventTrack")]
    public class UMovieSceneEventTrack : UMovieSceneNameableTrack
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}