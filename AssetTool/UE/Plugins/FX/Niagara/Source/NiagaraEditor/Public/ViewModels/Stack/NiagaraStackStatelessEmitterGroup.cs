namespace AssetTool
{
    [JsonAsset("NiagaraStackStatelessEmitterGroup")]
    public class UNiagaraStackStatelessEmitterGroup : UNiagaraStackItemGroup
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraStackStatelessEmitterObjectItem")]
    public class UNiagaraStackStatelessEmitterObjectItem : UNiagaraStackItem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}