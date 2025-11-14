namespace AssetTool
{
    [JsonAsset("AvaFontConfig")]
    public class UAvaFontConfig : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AvaFontManagerSubsystem")]
    public class UAvaFontManagerSubsystem : UEditorSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}