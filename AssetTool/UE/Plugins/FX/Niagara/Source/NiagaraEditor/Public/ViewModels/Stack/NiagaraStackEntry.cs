namespace AssetTool
{
    [JsonAsset("NiagaraStackEntry")]
    public class UNiagaraStackEntry : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraStackSpacer")]
    public class UNiagaraStackSpacer : UNiagaraStackEntry
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}