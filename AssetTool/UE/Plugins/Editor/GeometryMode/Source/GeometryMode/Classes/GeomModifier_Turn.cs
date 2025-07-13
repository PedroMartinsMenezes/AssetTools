namespace AssetTool
{
    [JsonAsset("GeomModifier_Turn")]
    public class UGeomModifier_Turn : UGeomModifier_Edit
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}