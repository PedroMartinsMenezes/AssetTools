namespace AssetTool
{
    [JsonAsset("MovieSceneObjectPropertySection")]
    public class UMovieSceneObjectPropertySection : UMovieSceneSection
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}