namespace AssetTool
{
    [JsonAsset("DynamicMaterialEditorSettings")]
    public class UDynamicMaterialEditorSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}