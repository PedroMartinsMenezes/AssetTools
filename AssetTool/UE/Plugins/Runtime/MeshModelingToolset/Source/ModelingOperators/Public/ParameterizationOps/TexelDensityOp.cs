namespace AssetTool
{
    [JsonAsset("UVEditorTexelDensitySettings")]
    public class UUVEditorTexelDensitySettings : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UVTexelDensityOperatorFactory")]
    public class UUVTexelDensityOperatorFactory : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}