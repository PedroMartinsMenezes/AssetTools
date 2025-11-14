namespace AssetTool
{
    [JsonAsset("DynamicMaterialEditorSettings")]
    public class UDynamicMaterialEditorSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}