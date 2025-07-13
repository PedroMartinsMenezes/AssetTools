namespace AssetTool
{
    [JsonAsset("BaseCompositeCommand")]
    public class UBaseCompositeCommand : UUTBBaseCommand
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}