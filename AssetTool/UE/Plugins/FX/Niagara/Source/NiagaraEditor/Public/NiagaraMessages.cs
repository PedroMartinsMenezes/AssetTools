namespace AssetTool
{
    [JsonAsset("NiagaraMessageData")]
    public class UNiagaraMessageData : UNiagaraMessageDataBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraMessageDataText")]
    public class UNiagaraMessageDataText : UNiagaraMessageData
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}