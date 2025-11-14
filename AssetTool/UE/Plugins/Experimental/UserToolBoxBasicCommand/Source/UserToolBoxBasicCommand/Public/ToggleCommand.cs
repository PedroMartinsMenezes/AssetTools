namespace AssetTool
{
    [JsonAsset("ToggleCommand")]
    public class UToggleCommand : UBaseCompositeCommand
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}