namespace AssetTool
{
    [JsonAsset("EditorInstancedPlacementSettings")]
    public class UEditorInstancedPlacementSettings : UInstancedPlacemenClientSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}