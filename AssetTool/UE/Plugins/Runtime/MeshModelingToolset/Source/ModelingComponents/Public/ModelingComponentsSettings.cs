namespace AssetTool
{
    [JsonAsset("ModelingComponentsSettings")]
    public class UModelingComponentsSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ModelingComponentsEditorSettings")]
    public class UModelingComponentsEditorSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}