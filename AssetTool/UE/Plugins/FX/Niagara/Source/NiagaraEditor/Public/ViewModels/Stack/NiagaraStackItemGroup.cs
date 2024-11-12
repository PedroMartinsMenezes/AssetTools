namespace AssetTool
{
    [JsonAsset("NiagaraStackItemGroup")]
    public class UNiagaraStackItemGroup : UNiagaraStackEntry
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraStackItemGroupFooter")]
    public class UNiagaraStackItemGroupFooter : UNiagaraStackEntry
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}