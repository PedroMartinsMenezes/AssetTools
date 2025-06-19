namespace AssetTool
{
    [JsonAsset("EditorUtilityToolMenuEntry")]
    public class UEditorUtilityToolMenuEntry : UToolMenuEntryScript
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("EditorUtilityToolMenuSection")]
    public class UEditorUtilityToolMenuSection : UToolMenuSectionDynamic
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}