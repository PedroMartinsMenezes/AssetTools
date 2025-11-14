namespace AssetTool
{
    [JsonAsset("MovieSceneNameableTrack")]
    public class UMovieSceneNameableTrack : UMovieSceneTrack
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}