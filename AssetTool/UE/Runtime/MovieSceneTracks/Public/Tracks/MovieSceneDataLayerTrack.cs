namespace AssetTool
{
    [JsonAsset("MovieSceneDataLayerTrack")]
    public class UMovieSceneDataLayerTrack : UMovieSceneNameableTrack
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}