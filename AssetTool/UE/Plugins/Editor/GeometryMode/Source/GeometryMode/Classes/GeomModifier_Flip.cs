namespace AssetTool
{
    [JsonAsset("GeomModifier_Flip")]
    public class UGeomModifier_Flip : UGeomModifier_Edit
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}