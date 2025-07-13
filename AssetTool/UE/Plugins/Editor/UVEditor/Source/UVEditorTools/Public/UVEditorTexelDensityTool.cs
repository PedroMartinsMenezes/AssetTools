namespace AssetTool
{
    [JsonAsset("UVEditorTexelDensityToolBuilder")]
    public class UUVEditorTexelDensityToolBuilder : UInteractiveToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UVEditorTexelDensityActionSettings")]
    public class UUVEditorTexelDensityActionSettings : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UVEditorTexelDensityToolSettings")]
    public class UUVEditorTexelDensityToolSettings : UUVEditorTexelDensitySettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UVEditorTexelDensityTool")]
    public class UUVEditorTexelDensityTool : UInteractiveTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}