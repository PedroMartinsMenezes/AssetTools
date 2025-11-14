namespace AssetTool
{
    [JsonAsset("DataDrivenCVarEngineSubsystem")]
    public class UDataDrivenCVarEngineSubsystem : UEngineSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DataDrivenConsoleVariableSettings")]
    public class UDataDrivenConsoleVariableSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}