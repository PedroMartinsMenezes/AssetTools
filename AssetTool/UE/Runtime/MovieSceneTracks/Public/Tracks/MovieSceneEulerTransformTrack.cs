namespace AssetTool
{
    [JsonAsset("MovieSceneEulerTransformTrack")]
    public class UMovieSceneEulerTransformTrack : UMovieScenePropertyTrack
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}