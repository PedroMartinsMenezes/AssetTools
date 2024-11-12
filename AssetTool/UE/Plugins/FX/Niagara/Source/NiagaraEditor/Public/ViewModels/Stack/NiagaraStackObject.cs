namespace AssetTool
{
    [JsonAsset("NiagaraStackObject")]
    public class UNiagaraStackObject : UNiagaraStackItemContent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}