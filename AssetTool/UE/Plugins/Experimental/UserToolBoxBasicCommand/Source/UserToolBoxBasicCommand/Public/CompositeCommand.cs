namespace AssetTool
{
    [JsonAsset("CompositeCommand")]
    public class UCompositeCommand : UBaseCompositeCommand
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}