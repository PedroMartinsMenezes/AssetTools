namespace AssetTool
{
    [JsonAsset("TextureShareWorldSubsystem")]
    public class UTextureShareWorldSubsystem : UTickableWorldSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}