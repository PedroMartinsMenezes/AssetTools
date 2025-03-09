namespace AssetTool
{
    [JsonAsset("EditorUtilityBlueprint")]
    public class UEditorUtilityBlueprint : UBlueprint
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}