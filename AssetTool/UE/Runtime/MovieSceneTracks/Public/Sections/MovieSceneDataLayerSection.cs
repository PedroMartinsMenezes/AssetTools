namespace AssetTool
{
    [JsonAsset("MovieSceneDataLayerSection")]
    public class UMovieSceneDataLayerSection : UMovieSceneSection
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}