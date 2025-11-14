namespace AssetTool
{
    [JsonAsset("NiagaraSpriteRendererProperties")]
    public class UNiagaraSpriteRendererProperties : UNiagaraRendererProperties
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}