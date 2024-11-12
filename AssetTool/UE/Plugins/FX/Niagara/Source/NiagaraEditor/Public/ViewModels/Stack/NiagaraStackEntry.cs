namespace AssetTool
{
    [JsonAsset("NiagaraStackEntry")]
    public class UNiagaraStackEntry : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraStackSpacer")]
    public class UNiagaraStackSpacer : UNiagaraStackEntry
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}