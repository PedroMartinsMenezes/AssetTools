namespace AssetTool
{
    [JsonAsset("MovieSceneTransformTrack")]
    public class UMovieSceneTransformTrack : UMovieScenePropertyTrack
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}