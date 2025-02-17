namespace AssetTool
{
    [JsonAsset("K2Node_GetSubsystem")]
    public class UK2Node_GetSubsystem : UK2Node
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("K2Node_GetSubsystemFromPC")]
    public class UK2Node_GetSubsystemFromPC : UK2Node_GetSubsystem
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("K2Node_GetEngineSubsystem")]
    public class UK2Node_GetEngineSubsystem : UK2Node_GetSubsystem
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("K2Node_GetEditorSubsystem")]
    public class UK2Node_GetEditorSubsystem : UK2Node_GetSubsystem
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}