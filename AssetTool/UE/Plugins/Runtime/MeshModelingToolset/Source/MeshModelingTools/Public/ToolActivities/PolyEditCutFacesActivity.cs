namespace AssetTool
{
    [JsonAsset("PolyEditCutProperties")]
    public class UPolyEditCutProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PolyEditCutFacesActivity")]
    public class UPolyEditCutFacesActivity : UInteractiveToolActivity
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}