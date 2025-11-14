namespace AssetTool
{
    [JsonAsset("GameplayDebuggerConfig")]
    public class UGameplayDebuggerConfig : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("GameplayDebuggerUserSettings")]
    public class UGameplayDebuggerUserSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}