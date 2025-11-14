namespace AssetTool
{
    [JsonAsset("MovieSceneParticleTrack")]
    public class UMovieSceneParticleTrack : UMovieSceneNameableTrack
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}