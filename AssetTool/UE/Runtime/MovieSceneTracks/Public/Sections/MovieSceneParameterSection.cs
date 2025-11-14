namespace AssetTool
{
    [JsonAsset("MovieSceneParameterSection")]
    public class UMovieSceneParameterSection : UMovieSceneSection
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}