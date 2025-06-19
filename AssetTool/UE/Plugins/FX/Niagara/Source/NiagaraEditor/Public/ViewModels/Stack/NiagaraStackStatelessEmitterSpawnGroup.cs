namespace AssetTool
{
    [JsonAsset("NiagaraStackStatelessEmitterSpawnGroup")]
    public class UNiagaraStackStatelessEmitterSpawnGroup : UNiagaraStackItemGroup
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraStackStatelessEmitterSpawnItem")]
    public class UNiagaraStackStatelessEmitterSpawnItem : UNiagaraStackItem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}