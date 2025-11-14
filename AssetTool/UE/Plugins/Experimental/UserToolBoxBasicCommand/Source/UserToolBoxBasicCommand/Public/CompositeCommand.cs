namespace AssetTool
{
    [JsonAsset("CompositeCommand")]
    public class UCompositeCommand : UBaseCompositeCommand
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}