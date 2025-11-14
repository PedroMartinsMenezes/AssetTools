namespace AssetTool
{
    [JsonAsset("GroupEdgeInsertionProperties")]
    public class UGroupEdgeInsertionProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PolyEditInsertEdgeActivity")]
    public class UPolyEditInsertEdgeActivity : UInteractiveToolActivity
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}