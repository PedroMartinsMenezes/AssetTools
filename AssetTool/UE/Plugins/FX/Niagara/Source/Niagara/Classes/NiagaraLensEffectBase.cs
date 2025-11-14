namespace AssetTool
{
    [JsonAsset("NiagaraLensEffectBase")]
    public class ANiagaraLensEffectBase : ANiagaraActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}