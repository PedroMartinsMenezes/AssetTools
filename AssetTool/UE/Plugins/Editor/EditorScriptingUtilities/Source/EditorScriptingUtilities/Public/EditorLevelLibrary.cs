namespace AssetTool
{
    [JsonAsset("EditorLevelLibrary")]
    public class UEditorLevelLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}