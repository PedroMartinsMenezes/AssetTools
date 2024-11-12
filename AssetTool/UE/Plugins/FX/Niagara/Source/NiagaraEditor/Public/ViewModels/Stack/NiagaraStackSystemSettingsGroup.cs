namespace AssetTool
{
    [JsonAsset("NiagaraStackSystemPropertiesGroup")]
    public class UNiagaraStackSystemPropertiesGroup : UNiagaraStackItemGroup
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraStackSystemUserParametersGroup")]
    public class UNiagaraStackSystemUserParametersGroup : UNiagaraStackItemGroup
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}