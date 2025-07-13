namespace AssetTool
{
    [JsonAsset("ZoneShapeComponent")]
    public class UZoneShapeComponent : UPrimitiveComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}