namespace AssetTool
{
    [JsonAsset("SynthesisEditorSettings")]
    public class USynthesisEditorSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}