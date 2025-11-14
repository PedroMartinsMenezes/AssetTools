namespace AssetTool
{
    [JsonAsset("NiagaraSettings")]
    public class UNiagaraSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}