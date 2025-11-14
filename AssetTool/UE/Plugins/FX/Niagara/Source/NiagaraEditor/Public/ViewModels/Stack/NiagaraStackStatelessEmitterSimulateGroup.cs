namespace AssetTool
{
    [JsonAsset("NiagaraStackStatelessEmitterSimulateGroup")]
    public class UNiagaraStackStatelessEmitterSimulateGroup : UNiagaraStackItemGroup
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraStackStatelessModuleItem")]
    public class UNiagaraStackStatelessModuleItem : UNiagaraStackItem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}