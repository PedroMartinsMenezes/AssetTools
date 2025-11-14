namespace AssetTool
{
    [JsonAsset("NiagaraNodeParameterMapFor")]
    public class UNiagaraNodeParameterMapFor : UNiagaraNodeParameterMapSet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraNodeParameterMapForWithContinue")]
    public class UNiagaraNodeParameterMapForWithContinue : UNiagaraNodeParameterMapFor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraNodeParameterMapForIndex")]
    public class UNiagaraNodeParameterMapForIndex : UNiagaraNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}