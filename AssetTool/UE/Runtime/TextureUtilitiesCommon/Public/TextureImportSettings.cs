namespace AssetTool
{
    [JsonAsset("TextureImportSettings")]
    public class UTextureImportSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}