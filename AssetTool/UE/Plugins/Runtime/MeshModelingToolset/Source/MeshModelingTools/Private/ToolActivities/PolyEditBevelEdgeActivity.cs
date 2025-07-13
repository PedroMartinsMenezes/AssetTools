namespace AssetTool
{
    [JsonAsset("PolyEditBevelEdgeProperties")]
    public class UPolyEditBevelEdgeProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PolyEditBevelEdgeActivity")]
    public class UPolyEditBevelEdgeActivity : UInteractiveToolActivity
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}