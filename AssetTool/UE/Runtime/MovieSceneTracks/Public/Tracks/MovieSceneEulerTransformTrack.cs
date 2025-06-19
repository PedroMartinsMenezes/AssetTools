namespace AssetTool
{
    [JsonAsset("MovieSceneEulerTransformTrack")]
    public class UMovieSceneEulerTransformTrack : UMovieScenePropertyTrack
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}