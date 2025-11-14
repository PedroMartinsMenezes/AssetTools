namespace AssetTool
{
    [JsonAsset("PolyEditBevelEdgeProperties")]
    public class UPolyEditBevelEdgeProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PolyEditBevelEdgeActivity")]
    public class UPolyEditBevelEdgeActivity : UInteractiveToolActivity
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}