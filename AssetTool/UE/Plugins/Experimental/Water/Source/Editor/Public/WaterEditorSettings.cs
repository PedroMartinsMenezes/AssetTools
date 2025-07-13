namespace AssetTool
{
    [JsonAsset("WaterEditorSettings")]
    public class UWaterEditorSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}