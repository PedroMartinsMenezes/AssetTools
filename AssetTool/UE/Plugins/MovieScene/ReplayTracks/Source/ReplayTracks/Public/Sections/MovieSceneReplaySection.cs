namespace AssetTool
{
    [JsonAsset("MovieSceneReplaySection")]
    public class UMovieSceneReplaySection : UMovieSceneSection
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}