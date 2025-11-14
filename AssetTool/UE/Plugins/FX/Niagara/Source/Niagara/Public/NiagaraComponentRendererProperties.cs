namespace AssetTool
{
    [JsonAsset("NiagaraComponentRendererProperties")]
    public class UNiagaraComponentRendererProperties : UNiagaraRendererProperties
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}