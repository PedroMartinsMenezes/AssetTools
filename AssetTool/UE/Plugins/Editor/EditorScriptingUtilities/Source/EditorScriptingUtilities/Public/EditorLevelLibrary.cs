namespace AssetTool
{
    [JsonAsset("EditorLevelLibrary")]
    public class UEditorLevelLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}