namespace AssetTool
{
    [JsonAsset("PolyEditInsetOutsetProperties")]
    public class UPolyEditInsetOutsetProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PolyEditInsetOutsetActivity")]
    public class UPolyEditInsetOutsetActivity : UInteractiveToolActivity
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}