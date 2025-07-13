namespace AssetTool
{
    [JsonAsset("CEClonerLibrary")]
    public class UCEClonerLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}