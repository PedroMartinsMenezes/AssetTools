namespace AssetTool
{
    [JsonAsset("GeometryMaskSettings")]
    public class UGeometryMaskSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}