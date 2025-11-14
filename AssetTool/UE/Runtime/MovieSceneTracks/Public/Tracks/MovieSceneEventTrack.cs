namespace AssetTool
{
    [JsonAsset("MovieSceneEventTrack")]
    public class UMovieSceneEventTrack : UMovieSceneNameableTrack
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}