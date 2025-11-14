namespace AssetTool
{
    [JsonAsset("ImagePlateFrustumComponent")]
    public class UImagePlateFrustumComponent : UPrimitiveComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}