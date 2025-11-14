namespace AssetTool
{
    [JsonAsset("PolyEditExtrudeEdgeActivityProperties")]
    public class UPolyEditExtrudeEdgeActivityProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PolyEditExtrudeEdgeActivity")]
    public class UPolyEditExtrudeEdgeActivity : UInteractiveToolActivity
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}