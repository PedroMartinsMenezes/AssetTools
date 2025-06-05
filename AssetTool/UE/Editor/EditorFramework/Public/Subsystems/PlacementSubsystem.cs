namespace AssetTool
{
    [JsonAsset("PlacementSubsystem")]
    public class UPlacementSubsystem : UEditorSubsystem
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}