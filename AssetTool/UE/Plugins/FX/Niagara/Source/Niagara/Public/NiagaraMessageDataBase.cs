namespace AssetTool
{
    [JsonAsset("NiagaraMessageDataBase")]
    public class UNiagaraMessageDataBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}