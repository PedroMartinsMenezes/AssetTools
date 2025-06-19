namespace AssetTool
{
    [JsonAsset("NiagaraEditorSettings")]
    public class UNiagaraEditorSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}