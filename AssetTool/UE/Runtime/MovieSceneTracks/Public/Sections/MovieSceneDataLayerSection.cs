namespace AssetTool
{
    [JsonAsset("MovieSceneDataLayerSection")]
    public class UMovieSceneDataLayerSection : UMovieSceneSection
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}