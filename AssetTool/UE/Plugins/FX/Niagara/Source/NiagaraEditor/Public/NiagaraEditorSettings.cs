namespace AssetTool
{
    [JsonAsset("NiagaraEditorSettings")]
    public class UNiagaraEditorSettings : UDeveloperSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}