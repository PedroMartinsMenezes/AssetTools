namespace AssetTool
{
    [JsonAsset("MovieSceneNiagaraEmitterSectionBase")]
    public class UMovieSceneNiagaraEmitterSectionBase : UMovieSceneSection
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieSceneNiagaraEmitterTrack")]
    public class UMovieSceneNiagaraEmitterTrack : UMovieSceneNameableTrack
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}