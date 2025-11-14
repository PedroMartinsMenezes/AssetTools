namespace AssetTool
{
    [JsonAsset("ActionableMessageSubsystem")]
    public class UActionableMessageSubsystem : UWorldSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}