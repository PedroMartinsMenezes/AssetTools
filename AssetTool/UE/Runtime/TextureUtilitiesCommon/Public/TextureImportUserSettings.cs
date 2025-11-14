namespace AssetTool
{
    [JsonAsset("TextureImportUserSettings")]
    public class UTextureImportUserSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}