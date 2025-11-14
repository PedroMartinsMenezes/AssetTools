namespace AssetTool
{
    [JsonAsset("UVEditorTexelDensityToolBuilder")]
    public class UUVEditorTexelDensityToolBuilder : UInteractiveToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UVEditorTexelDensityActionSettings")]
    public class UUVEditorTexelDensityActionSettings : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UVEditorTexelDensityToolSettings")]
    public class UUVEditorTexelDensityToolSettings : UUVEditorTexelDensitySettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UVEditorTexelDensityTool")]
    public class UUVEditorTexelDensityTool : UInteractiveTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}