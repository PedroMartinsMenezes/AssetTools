namespace AssetTool
{
    [JsonAsset("MovieSceneStringTrack")]
    public class UMovieSceneStringTrack : UMovieScenePropertyTrack
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}