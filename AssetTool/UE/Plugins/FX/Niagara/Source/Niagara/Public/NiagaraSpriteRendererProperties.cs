namespace AssetTool
{
    [JsonAsset("NiagaraSpriteRendererProperties")]
    public class UNiagaraSpriteRendererProperties : UNiagaraRendererProperties
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}