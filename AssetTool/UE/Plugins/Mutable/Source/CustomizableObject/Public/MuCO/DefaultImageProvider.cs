namespace AssetTool
{
    [JsonAsset("DefaultImageProvider")]
    public class UDefaultImageProvider : UCustomizableSystemImageProvider
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}