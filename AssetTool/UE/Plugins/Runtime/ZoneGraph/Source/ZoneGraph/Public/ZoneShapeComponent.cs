namespace AssetTool
{
    [JsonAsset("ZoneShapeComponent")]
    public class UZoneShapeComponent : UPrimitiveComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}