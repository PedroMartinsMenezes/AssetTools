namespace AssetTool
{
    [JsonAsset("WaterEditorSettings")]
    public class UWaterEditorSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}