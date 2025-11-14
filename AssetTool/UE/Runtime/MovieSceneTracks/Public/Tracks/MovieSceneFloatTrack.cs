namespace AssetTool
{
    [JsonAsset("MovieSceneFloatTrack")]
    public class UMovieSceneFloatTrack : UMovieScenePropertyTrack
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}