namespace AssetTool
{
    [JsonAsset("PlacementSubsystem")]
    public class UPlacementSubsystem : UEditorSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}