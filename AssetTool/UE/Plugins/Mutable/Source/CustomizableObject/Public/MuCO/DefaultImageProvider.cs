namespace AssetTool
{
    [JsonAsset("DefaultImageProvider")]
    public class UDefaultImageProvider : UCustomizableSystemImageProvider
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}