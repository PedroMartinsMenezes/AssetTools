namespace AssetTool
{
    [JsonAsset("GeomModifier_Create")]
    public class UGeomModifier_Create : UGeomModifier_Edit
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}