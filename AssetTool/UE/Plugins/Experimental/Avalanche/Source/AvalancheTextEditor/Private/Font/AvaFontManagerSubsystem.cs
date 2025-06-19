namespace AssetTool
{
    [JsonAsset("AvaFontConfig")]
    public class UAvaFontConfig : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AvaFontManagerSubsystem")]
    public class UAvaFontManagerSubsystem : UEditorSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}