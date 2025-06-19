namespace AssetTool
{
    [JsonAsset("NiagaraSpriteRendererProperties")]
    public class UNiagaraSpriteRendererProperties : UNiagaraRendererProperties
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}