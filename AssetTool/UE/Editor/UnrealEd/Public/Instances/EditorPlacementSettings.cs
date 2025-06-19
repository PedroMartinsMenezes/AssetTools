namespace AssetTool
{
    [JsonAsset("EditorInstancedPlacementSettings")]
    public class UEditorInstancedPlacementSettings : UInstancedPlacemenClientSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}