namespace AssetTool
{
    [JsonAsset("TextureImportUserSettings")]
    public class UTextureImportUserSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}