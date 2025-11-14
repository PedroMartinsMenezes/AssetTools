namespace AssetTool
{
    [JsonAsset("NiagaraSequence")]
    public class UNiagaraSequence : UMovieSceneSequence
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}