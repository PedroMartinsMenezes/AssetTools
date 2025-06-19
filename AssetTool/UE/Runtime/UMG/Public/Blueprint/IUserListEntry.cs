namespace AssetTool
{
    [JsonAsset("UserListEntryLibrary")]
    public class UUserListEntryLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}