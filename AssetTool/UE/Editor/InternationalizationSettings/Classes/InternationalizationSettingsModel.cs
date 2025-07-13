namespace AssetTool
{
    [JsonAsset("InternationalizationSettingsModel")]
    public class UInternationalizationSettingsModel : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}