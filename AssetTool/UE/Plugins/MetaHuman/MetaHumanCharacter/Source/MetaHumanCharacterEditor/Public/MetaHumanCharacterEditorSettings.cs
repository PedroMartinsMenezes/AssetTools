namespace AssetTool
{
    [JsonAsset("MetaHumanCharacterEditorSettings")]
    public class UMetaHumanCharacterEditorSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}