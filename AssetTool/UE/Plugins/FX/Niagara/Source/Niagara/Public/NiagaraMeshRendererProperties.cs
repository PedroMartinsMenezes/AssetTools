namespace AssetTool
{
    [JsonAsset("NiagaraMeshRendererProperties")]
    public class UNiagaraMeshRendererProperties : UNiagaraRendererProperties
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}