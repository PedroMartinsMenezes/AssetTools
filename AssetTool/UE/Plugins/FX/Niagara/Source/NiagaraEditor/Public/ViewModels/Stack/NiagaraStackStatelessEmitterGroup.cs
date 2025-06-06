namespace AssetTool
{
    [JsonAsset("NiagaraStackStatelessEmitterGroup")]
    public class UNiagaraStackStatelessEmitterGroup : UNiagaraStackItemGroup
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraStackStatelessEmitterObjectItem")]
    public class UNiagaraStackStatelessEmitterObjectItem : UNiagaraStackItem
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}