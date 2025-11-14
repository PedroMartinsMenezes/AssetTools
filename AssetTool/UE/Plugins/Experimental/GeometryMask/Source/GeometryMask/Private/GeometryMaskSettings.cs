namespace AssetTool
{
    [JsonAsset("GeometryMaskSettings")]
    public class UGeometryMaskSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}