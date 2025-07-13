namespace AssetTool
{
    [JsonAsset("TextureImportSettings")]
    public class UTextureImportSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}