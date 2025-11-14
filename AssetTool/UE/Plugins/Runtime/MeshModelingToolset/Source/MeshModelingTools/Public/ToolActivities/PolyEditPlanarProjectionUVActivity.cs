namespace AssetTool
{
    [JsonAsset("PolyEditSetUVProperties")]
    public class UPolyEditSetUVProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PolyEditPlanarProjectionUVActivity")]
    public class UPolyEditPlanarProjectionUVActivity : UInteractiveToolActivity
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}