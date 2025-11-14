namespace AssetTool
{
    [JsonAsset("NiagaraEditorSettings")]
    public class UNiagaraEditorSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}