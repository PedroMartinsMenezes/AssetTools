namespace AssetTool
{
    [JsonAsset("NiagaraSettings")]
    public class UNiagaraSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}