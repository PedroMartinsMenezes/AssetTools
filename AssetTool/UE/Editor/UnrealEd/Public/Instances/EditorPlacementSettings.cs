namespace AssetTool
{
    [JsonAsset("EditorInstancedPlacementSettings")]
    public class UEditorInstancedPlacementSettings : UInstancedPlacemenClientSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}