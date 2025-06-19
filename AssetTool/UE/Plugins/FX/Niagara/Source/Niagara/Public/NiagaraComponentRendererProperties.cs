namespace AssetTool
{
    [JsonAsset("NiagaraComponentRendererProperties")]
    public class UNiagaraComponentRendererProperties : UNiagaraRendererProperties
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}