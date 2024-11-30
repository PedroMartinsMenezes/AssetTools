namespace AssetTool
{
    [JsonAsset("NiagaraSequence")]
    public class UNiagaraSequence : UMovieSceneSequence
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}