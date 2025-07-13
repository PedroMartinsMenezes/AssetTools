namespace AssetTool
{
    [JsonAsset("PLUGIN_NAMESimpleToolBuilder")]
    public class UPLUGIN_NAMESimpleToolBuilder : UInteractiveToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PLUGIN_NAMESimpleToolProperties")]
    public class UPLUGIN_NAMESimpleToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PLUGIN_NAMESimpleTool")]
    public class UPLUGIN_NAMESimpleTool : USingleClickTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}