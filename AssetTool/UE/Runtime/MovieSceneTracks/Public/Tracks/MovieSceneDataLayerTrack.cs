namespace AssetTool
{
    [JsonAsset("MovieSceneDataLayerTrack")]
    public class UMovieSceneDataLayerTrack : UMovieSceneNameableTrack
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}