namespace AssetTool
{
    [JsonAsset("GameFeaturesEditorSettings")]
    public class UGameFeaturesEditorSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}