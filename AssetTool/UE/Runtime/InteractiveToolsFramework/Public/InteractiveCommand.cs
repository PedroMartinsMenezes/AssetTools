namespace AssetTool
{
    [JsonAsset("InteractiveCommandArguments")]
    public class UInteractiveCommandArguments : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InteractiveCommandResult")]
    public class UInteractiveCommandResult : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InteractiveCommand")]
    public class UInteractiveCommand : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}