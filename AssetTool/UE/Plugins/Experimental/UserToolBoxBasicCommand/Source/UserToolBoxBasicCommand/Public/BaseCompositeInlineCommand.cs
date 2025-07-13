namespace AssetTool
{
    [JsonAsset("BaseCompositeInlineCommand")]
    public class UBaseCompositeInlineCommand : UUTBBaseCommand
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}