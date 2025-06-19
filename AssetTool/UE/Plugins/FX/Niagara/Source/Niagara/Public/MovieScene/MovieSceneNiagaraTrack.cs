namespace AssetTool
{
    [JsonAsset("MovieSceneNiagaraTrack")]
    public class UMovieSceneNiagaraTrack : UMovieSceneNameableTrack
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}