namespace AssetTool
{
    [JsonAsset("PlacementSubsystem")]
    public class UPlacementSubsystem : UEditorSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}