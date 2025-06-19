namespace AssetTool
{
    [JsonAsset("MovieSceneColorTrack")]
    public class UMovieSceneColorTrack : UMovieScenePropertyTrack
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}