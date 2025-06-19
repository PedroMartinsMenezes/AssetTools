namespace AssetTool
{
    [JsonAsset("NiagaraSequence")]
    public class UNiagaraSequence : UMovieSceneSequence
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}