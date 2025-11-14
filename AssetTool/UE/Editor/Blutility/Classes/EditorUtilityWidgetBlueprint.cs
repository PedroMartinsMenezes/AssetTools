namespace AssetTool
{
    [JsonAsset("EditorUtilityWidgetBlueprint")]
    public class UEditorUtilityWidgetBlueprint : UWidgetBlueprint
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}