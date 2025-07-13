namespace AssetTool
{
    [JsonAsset("MultiUserTakesFunctionLibrary")]
    public class UMultiUserTakesFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}