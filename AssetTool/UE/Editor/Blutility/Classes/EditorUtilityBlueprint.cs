namespace AssetTool
{
    [JsonAsset("EditorUtilityBlueprint")]
    public class UEditorUtilityBlueprint : UBlueprint
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}