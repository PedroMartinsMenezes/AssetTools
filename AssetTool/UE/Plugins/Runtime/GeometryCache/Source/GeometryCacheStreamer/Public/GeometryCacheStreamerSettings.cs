namespace AssetTool
{
    [JsonAsset("GeometryCacheStreamerSettings")]
    public class UGeometryCacheStreamerSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}