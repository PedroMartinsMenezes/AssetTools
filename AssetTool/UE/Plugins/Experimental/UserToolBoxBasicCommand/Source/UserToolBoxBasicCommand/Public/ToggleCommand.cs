namespace AssetTool
{
    [JsonAsset("ToggleCommand")]
    public class UToggleCommand : UBaseCompositeCommand
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}