namespace AssetTool
{
    [JsonAsset("NiagaraMeshRendererProperties")]
    public class UNiagaraMeshRendererProperties : UNiagaraRendererProperties
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}