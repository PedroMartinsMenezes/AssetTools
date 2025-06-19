namespace AssetTool
{
    [JsonAsset("PlatformGameInstance")]
    public class UPlatformGameInstance : UGameInstance
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("BlueprintPlatformLibrary")]
    public class UBlueprintPlatformLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}