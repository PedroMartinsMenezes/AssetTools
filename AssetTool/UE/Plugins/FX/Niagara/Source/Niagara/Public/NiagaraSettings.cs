namespace AssetTool
{
    [JsonAsset("NiagaraSettings")]
    public class UNiagaraSettings : UDeveloperSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}