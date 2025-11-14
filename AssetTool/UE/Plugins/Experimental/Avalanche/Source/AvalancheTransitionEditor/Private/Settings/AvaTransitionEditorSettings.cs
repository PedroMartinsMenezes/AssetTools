namespace AssetTool
{
    [JsonAsset("AvaTransitionEditorSettings")]
    public class UAvaTransitionEditorSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}