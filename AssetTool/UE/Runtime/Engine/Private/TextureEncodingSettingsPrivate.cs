namespace AssetTool
{
    [JsonAsset("TextureEncodingProjectSettings")]
    public class UTextureEncodingProjectSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TextureEncodingUserSettings")]
    public class UTextureEncodingUserSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}