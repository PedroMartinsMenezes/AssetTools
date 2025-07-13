namespace AssetTool
{
    [JsonAsset("UVEditorTexelDensitySettings")]
    public class UUVEditorTexelDensitySettings : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UVTexelDensityOperatorFactory")]
    public class UUVTexelDensityOperatorFactory : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}