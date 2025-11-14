namespace AssetTool
{
    [JsonAsset("GameFeaturesEditorSettings")]
    public class UGameFeaturesEditorSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}