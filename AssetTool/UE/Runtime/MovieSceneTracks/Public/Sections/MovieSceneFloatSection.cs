namespace AssetTool
{
    [JsonAsset("MovieSceneFloatSection")]
    public class UMovieSceneFloatSection : UMovieSceneSection
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}