namespace AssetTool
{
    [JsonAsset("MultiUserClientSyncDatabase")]
    public class UMultiUserClientSyncDatabase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MultiUserClientStatics")]
    public class UMultiUserClientStatics : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}