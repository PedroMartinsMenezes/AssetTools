namespace AssetTool
{
    [JsonAsset("BaseCompositeCommand")]
    public class UBaseCompositeCommand : UUTBBaseCommand
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}