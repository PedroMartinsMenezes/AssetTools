namespace AssetTool
{
    [JsonAsset("NiagaraStackSelection")]
    public class UNiagaraStackSelection : UNiagaraStackEntry
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}