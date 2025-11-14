namespace AssetTool
{
    [JsonAsset("ZoneGraphRenderingComponent")]
    public class UZoneGraphRenderingComponent : UPrimitiveComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}