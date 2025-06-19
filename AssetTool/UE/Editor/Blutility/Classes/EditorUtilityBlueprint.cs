namespace AssetTool
{
    [JsonAsset("EditorUtilityBlueprint")]
    public class UEditorUtilityBlueprint : UBlueprint
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}