namespace AssetTool
{
    [JsonAsset("TextureShareObject")]
    public class UTextureShareObject : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TextureShare")]
    public class UTextureShare : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}