namespace AssetTool
{
    [JsonAsset("MovieSceneFloatSection")]
    public class UMovieSceneFloatSection : UMovieSceneSection
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}