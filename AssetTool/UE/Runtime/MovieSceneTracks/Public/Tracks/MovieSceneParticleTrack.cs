namespace AssetTool
{
    [JsonAsset("MovieSceneParticleTrack")]
    public class UMovieSceneParticleTrack : UMovieSceneNameableTrack
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}