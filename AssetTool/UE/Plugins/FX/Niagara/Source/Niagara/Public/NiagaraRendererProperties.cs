namespace AssetTool
{
    [JsonAsset("NiagaraRendererProperties")]
    public class UNiagaraRendererProperties : UNiagaraMergeable
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}