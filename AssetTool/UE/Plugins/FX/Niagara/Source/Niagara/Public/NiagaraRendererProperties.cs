namespace AssetTool
{
    [JsonAsset("NiagaraRendererProperties")]
    public class UNiagaraRendererProperties : UNiagaraMergeable
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}