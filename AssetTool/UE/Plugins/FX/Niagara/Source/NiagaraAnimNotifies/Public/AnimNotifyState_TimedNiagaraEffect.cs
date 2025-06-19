namespace AssetTool
{
    [JsonAsset("AnimNotifyState_TimedNiagaraEffect")]
    public class UAnimNotifyState_TimedNiagaraEffect : UAnimNotifyState
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AnimNotifyState_TimedNiagaraEffectAdvanced")]
    public class UAnimNotifyState_TimedNiagaraEffectAdvanced : UAnimNotifyState_TimedNiagaraEffect
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}