namespace AssetTool
{
    [JsonAsset("EditorAssetLibrary")]
    public class UEditorAssetLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}