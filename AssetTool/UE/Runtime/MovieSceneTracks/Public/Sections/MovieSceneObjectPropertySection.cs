namespace AssetTool
{
    [JsonAsset("MovieSceneObjectPropertySection")]
    public class  UMovieSceneObjectPropertySection : UMovieSceneSection
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}