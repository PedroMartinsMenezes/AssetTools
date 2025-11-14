namespace AssetTool
{
    [JsonAsset("CEClonerLibrary")]
    public class UCEClonerLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}