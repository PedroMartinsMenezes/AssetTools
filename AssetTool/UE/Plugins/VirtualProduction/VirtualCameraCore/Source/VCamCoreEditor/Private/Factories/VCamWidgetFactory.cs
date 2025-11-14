namespace AssetTool
{
    [JsonAsset("VCamWidgetFactory")]
    public class UVCamWidgetFactory : UVCamObjectWithInputFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}