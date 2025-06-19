namespace AssetTool
{
    [JsonAsset("NiagaraStackObject")]
    public class UNiagaraStackObject : UNiagaraStackItemContent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}