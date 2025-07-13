namespace AssetTool
{
    [JsonAsset("StageAppSettings")]
    public class UStageAppSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}