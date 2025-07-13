namespace AssetTool
{
    [JsonAsset("SynthesisEditorSettings")]
    public class USynthesisEditorSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}