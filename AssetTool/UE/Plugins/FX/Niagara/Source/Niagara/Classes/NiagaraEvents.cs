namespace AssetTool
{
    [JsonAsset("NiagaraEventReceiverEmitterAction")]
    public class UNiagaraEventReceiverEmitterAction : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraEventReceiverEmitterAction_SpawnParticles")]
    public class UNiagaraEventReceiverEmitterAction_SpawnParticles : UNiagaraEventReceiverEmitterAction
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}