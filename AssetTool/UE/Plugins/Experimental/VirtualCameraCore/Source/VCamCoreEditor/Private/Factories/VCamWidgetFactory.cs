namespace AssetTool
{
    [JsonAsset("VCamWidgetFactory")]
    public class UVCamWidgetFactory : UVCamObjectWithInputFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}