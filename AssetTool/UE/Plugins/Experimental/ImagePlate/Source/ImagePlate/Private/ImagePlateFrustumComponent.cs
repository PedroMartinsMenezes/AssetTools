namespace AssetTool
{
    [JsonAsset("ImagePlateFrustumComponent")]
    public class UImagePlateFrustumComponent : UPrimitiveComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}