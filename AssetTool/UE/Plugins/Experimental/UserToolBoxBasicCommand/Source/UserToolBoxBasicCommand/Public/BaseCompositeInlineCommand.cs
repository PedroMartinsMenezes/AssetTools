namespace AssetTool
{
    [JsonAsset("BaseCompositeInlineCommand")]
    public class UBaseCompositeInlineCommand : UUTBBaseCommand
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}