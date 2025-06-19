namespace AssetTool
{
    [JsonAsset("NiagaraRendererProperties")]
    public class UNiagaraRendererProperties : UNiagaraMergeable
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}