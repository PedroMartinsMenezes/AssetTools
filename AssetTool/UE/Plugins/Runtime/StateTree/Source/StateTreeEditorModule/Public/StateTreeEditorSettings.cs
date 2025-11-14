namespace AssetTool
{
    [JsonAsset("StateTreeEditorSettings")]
    public class UStateTreeEditorSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}