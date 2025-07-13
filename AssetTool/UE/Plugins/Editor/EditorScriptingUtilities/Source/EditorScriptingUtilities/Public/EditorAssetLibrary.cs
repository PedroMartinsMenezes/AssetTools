namespace AssetTool
{
    [JsonAsset("EditorAssetLibrary")]
    public class UEditorAssetLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}