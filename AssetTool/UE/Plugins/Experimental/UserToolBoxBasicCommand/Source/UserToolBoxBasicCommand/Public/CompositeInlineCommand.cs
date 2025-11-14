namespace AssetTool
{
    [JsonAsset("CompositeInlineCommand")]
    public class UCompositeInlineCommand : UBaseCompositeInlineCommand
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}