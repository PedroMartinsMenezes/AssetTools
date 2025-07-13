namespace AssetTool
{
    [JsonAsset("CompositeInlineCommand")]
    public class UCompositeInlineCommand : UBaseCompositeInlineCommand
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}