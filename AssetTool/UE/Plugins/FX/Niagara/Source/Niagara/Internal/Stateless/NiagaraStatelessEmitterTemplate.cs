namespace AssetTool
{
    [JsonAsset("NiagaraStatelessEmitterTemplate")]
    public class UNiagaraStatelessEmitterTemplate : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraStatelessEmitterDefault")]
    public class UNiagaraStatelessEmitterDefault : UNiagaraStatelessEmitterTemplate
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraStatelessEmitterExample1")]
    public class UNiagaraStatelessEmitterExample1 : UNiagaraStatelessEmitterTemplate
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}