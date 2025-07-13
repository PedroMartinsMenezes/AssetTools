namespace AssetTool
{
    [JsonAsset("EdgeLoopInsertionProperties")]
    public class UEdgeLoopInsertionProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PolyEditInsertEdgeLoopActivity")]
    public class UPolyEditInsertEdgeLoopActivity : UInteractiveToolActivity
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}