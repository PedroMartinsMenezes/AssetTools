namespace AssetTool
{
    [JsonAsset("TextureShareSettings")]
    public class UTextureShareSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}