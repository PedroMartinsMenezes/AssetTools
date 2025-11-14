namespace AssetTool
{
    [JsonAsset("PolyEditCutProperties")]
    public class UPolyEditCutProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PolyEditCutFacesActivity")]
    public class UPolyEditCutFacesActivity : UInteractiveToolActivity
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}