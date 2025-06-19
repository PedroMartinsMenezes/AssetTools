namespace AssetTool
{
    [JsonAsset("NiagaraStackSystemPropertiesGroup")]
    public class UNiagaraStackSystemPropertiesGroup : UNiagaraStackItemGroup
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraStackSystemUserParametersGroup")]
    public class UNiagaraStackSystemUserParametersGroup : UNiagaraStackItemGroup
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}