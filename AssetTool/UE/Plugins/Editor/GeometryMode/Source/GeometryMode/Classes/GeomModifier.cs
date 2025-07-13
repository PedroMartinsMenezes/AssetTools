namespace AssetTool
{
    [JsonAsset("GeomModifier")]
    public class UGeomModifier : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}