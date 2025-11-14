namespace AssetTool
{
    [JsonAsset("NiagaraMessageDataBase")]
    public class UNiagaraMessageDataBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}