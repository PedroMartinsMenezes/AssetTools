namespace AssetTool
{
    [JsonAsset("MovieSceneParticleSection")]
    public class UMovieSceneParticleSection : UMovieSceneSection
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}