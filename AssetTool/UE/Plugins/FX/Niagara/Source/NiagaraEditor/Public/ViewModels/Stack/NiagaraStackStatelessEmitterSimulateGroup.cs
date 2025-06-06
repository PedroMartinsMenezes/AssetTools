namespace AssetTool
{
    [JsonAsset("NiagaraStackStatelessEmitterSimulateGroup")]
    public class UNiagaraStackStatelessEmitterSimulateGroup : UNiagaraStackItemGroup
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraStackStatelessModuleItem")]
    public class UNiagaraStackStatelessModuleItem : UNiagaraStackItem
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}