namespace AssetTool
{
    [JsonAsset("PLUGIN_NAMEInteractiveToolBuilder")]
    public class UPLUGIN_NAMEInteractiveToolBuilder : UInteractiveToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PLUGIN_NAMEInteractiveToolProperties")]
    public class UPLUGIN_NAMEInteractiveToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PLUGIN_NAMEInteractiveTool")]
    public class UPLUGIN_NAMEInteractiveTool : UInteractiveTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}