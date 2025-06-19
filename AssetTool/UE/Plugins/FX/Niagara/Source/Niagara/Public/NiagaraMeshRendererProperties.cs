namespace AssetTool
{
    [JsonAsset("NiagaraMeshRendererProperties")]
    public class UNiagaraMeshRendererProperties : UNiagaraRendererProperties
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}