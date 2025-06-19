namespace AssetTool
{
    [JsonAsset("MovieSceneParameterSection")]
    public class UMovieSceneParameterSection : UMovieSceneSection
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}