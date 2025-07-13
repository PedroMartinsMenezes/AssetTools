namespace AssetTool
{
    [JsonAsset("PolyEditExtrudeEdgeActivityProperties")]
    public class UPolyEditExtrudeEdgeActivityProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PolyEditExtrudeEdgeActivity")]
    public class UPolyEditExtrudeEdgeActivity : UInteractiveToolActivity
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}