namespace AssetTool
{
    [JsonAsset("NiagaraLensEffectBase")]
    public class ANiagaraLensEffectBase : ANiagaraActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}