namespace AssetTool
{
    [JsonAsset("PolyEditInsetOutsetProperties")]
    public class UPolyEditInsetOutsetProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PolyEditInsetOutsetActivity")]
    public class UPolyEditInsetOutsetActivity : UInteractiveToolActivity
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}