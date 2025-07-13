namespace AssetTool
{
    [JsonAsset("GeomModifier_Delete")]
    public class UGeomModifier_Delete : UGeomModifier_Edit
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}