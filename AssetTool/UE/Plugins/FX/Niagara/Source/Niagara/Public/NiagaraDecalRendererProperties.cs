namespace AssetTool
{
    [JsonAsset("NiagaraDecalRendererProperties")]
    public class UNiagaraDecalRendererProperties : UNiagaraRendererProperties
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}