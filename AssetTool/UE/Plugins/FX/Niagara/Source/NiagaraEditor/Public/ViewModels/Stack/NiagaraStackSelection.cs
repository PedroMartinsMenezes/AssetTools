namespace AssetTool
{
    [JsonAsset("NiagaraStackSelection")]
    public class UNiagaraStackSelection : UNiagaraStackEntry
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}