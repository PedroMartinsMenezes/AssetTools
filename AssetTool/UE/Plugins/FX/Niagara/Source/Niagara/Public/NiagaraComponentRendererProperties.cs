namespace AssetTool
{
    [JsonAsset("NiagaraComponentRendererProperties")]
    public class UNiagaraComponentRendererProperties : UNiagaraRendererProperties
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}