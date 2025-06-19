namespace AssetTool
{
    [JsonAsset("EditorUtilityWidgetBlueprint")]
    public class UEditorUtilityWidgetBlueprint : UWidgetBlueprint
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}