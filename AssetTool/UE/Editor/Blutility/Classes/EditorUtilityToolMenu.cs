namespace AssetTool
{
    [JsonAsset("EditorUtilityToolMenuEntry")]
    public class UEditorUtilityToolMenuEntry : UToolMenuEntryScript
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("EditorUtilityToolMenuSection")]
    public class UEditorUtilityToolMenuSection : UToolMenuSectionDynamic
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}