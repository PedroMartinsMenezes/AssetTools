namespace AssetTool
{
    [JsonAsset("VCamWidgetFactory")]
    public class UVCamWidgetFactory : UVCamObjectWithInputFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}