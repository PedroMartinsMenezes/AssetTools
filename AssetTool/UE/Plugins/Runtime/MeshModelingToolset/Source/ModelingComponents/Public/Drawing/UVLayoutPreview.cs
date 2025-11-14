namespace AssetTool
{
    [JsonAsset("UVLayoutPreviewProperties")]
    public class UUVLayoutPreviewProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UVLayoutPreview")]
    public class UUVLayoutPreview : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}