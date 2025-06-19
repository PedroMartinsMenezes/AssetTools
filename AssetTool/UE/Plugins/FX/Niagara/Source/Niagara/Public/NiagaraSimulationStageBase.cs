namespace AssetTool
{
    [JsonAsset("NiagaraSimulationStageBase")]
    public class UNiagaraSimulationStageBase : UNiagaraMergeable
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraSimulationStageGeneric")]
    public class UNiagaraSimulationStageGeneric : UNiagaraSimulationStageBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}