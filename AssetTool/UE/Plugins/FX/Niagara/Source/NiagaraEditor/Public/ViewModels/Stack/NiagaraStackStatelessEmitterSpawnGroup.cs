namespace AssetTool
{
    [JsonAsset("NiagaraStackStatelessEmitterSpawnGroup")]
    public class UNiagaraStackStatelessEmitterSpawnGroup : UNiagaraStackItemGroup
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraStackStatelessEmitterSpawnItem")]
    public class UNiagaraStackStatelessEmitterSpawnItem : UNiagaraStackItem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}