namespace AssetTool
{
    [JsonAsset("TextureShareWorldSubsystem")]
    public class UTextureShareWorldSubsystem : UTickableWorldSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}