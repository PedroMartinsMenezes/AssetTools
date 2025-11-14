namespace AssetTool
{
    [JsonAsset("NiagaraSignificanceHandler")]
    public class UNiagaraSignificanceHandler : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraSignificanceHandlerDistance")]
    public class UNiagaraSignificanceHandlerDistance : UNiagaraSignificanceHandler
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraSignificanceHandlerAge")]
    public class UNiagaraSignificanceHandlerAge : UNiagaraSignificanceHandler
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraEffectType")]
    public class UNiagaraEffectType : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}