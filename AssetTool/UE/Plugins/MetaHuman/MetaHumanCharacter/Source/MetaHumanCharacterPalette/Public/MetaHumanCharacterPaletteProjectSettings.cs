namespace AssetTool
{
    [JsonAsset("MetaHumanCharacterPaletteProjectSettings")]
    public class UMetaHumanCharacterPaletteProjectSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}