namespace AssetTool
{
    [JsonAsset("NiagaraStackItemGroup")]
    public class UNiagaraStackItemGroup : UNiagaraStackEntry
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraStackItemGroupFooter")]
    public class UNiagaraStackItemGroupFooter : UNiagaraStackEntry
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}