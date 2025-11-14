namespace AssetTool
{
    [JsonAsset("MetaHumanCharacterEditorSettings")]
    public class UMetaHumanCharacterEditorSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}