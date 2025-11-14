namespace AssetTool
{
    [JsonAsset("GeomModifier_Turn")]
    public class UGeomModifier_Turn : UGeomModifier_Edit
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}