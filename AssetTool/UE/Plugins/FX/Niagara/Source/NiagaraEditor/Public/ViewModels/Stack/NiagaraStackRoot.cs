namespace AssetTool
{
    [JsonAsset("NiagaraStackRoot")]
    public class UNiagaraStackRoot : UNiagaraStackEntry
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}