namespace AssetTool
{
    [JsonAsset("MultiUserTakesFunctionLibrary")]
    public class UMultiUserTakesFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}