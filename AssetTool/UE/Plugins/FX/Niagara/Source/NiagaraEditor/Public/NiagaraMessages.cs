namespace AssetTool
{
    [JsonAsset("NiagaraMessageData")]
    public class UNiagaraMessageData : UNiagaraMessageDataBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraMessageDataText")]
    public class UNiagaraMessageDataText : UNiagaraMessageData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}