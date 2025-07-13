namespace AssetTool
{
    [JsonAsset("VisualLoggerFilterVolume")]
    public class AVisualLoggerFilterVolume : AVolume
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}