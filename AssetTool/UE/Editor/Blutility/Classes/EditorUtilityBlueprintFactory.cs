namespace AssetTool
{
    [JsonAsset("EditorUtilityBlueprintFactory")]
    public class UEditorUtilityBlueprintFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}