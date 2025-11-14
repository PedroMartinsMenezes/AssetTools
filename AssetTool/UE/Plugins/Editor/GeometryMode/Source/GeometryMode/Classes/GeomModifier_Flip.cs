namespace AssetTool
{
    [JsonAsset("GeomModifier_Flip")]
    public class UGeomModifier_Flip : UGeomModifier_Edit
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}