namespace AssetTool
{
    [JsonAsset("UIExtensionSubsystem")]
    public class UUIExtensionSubsystem : UWorldSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UIExtensionHandleFunctions")]
    public class UUIExtensionHandleFunctions : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UIExtensionPointHandleFunctions")]
    public class UUIExtensionPointHandleFunctions : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}