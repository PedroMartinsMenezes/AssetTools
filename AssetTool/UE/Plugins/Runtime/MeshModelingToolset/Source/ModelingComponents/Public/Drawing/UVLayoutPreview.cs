namespace AssetTool
{
    [JsonAsset("UVLayoutPreviewProperties")]
    public class UUVLayoutPreviewProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UVLayoutPreview")]
    public class UUVLayoutPreview : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}