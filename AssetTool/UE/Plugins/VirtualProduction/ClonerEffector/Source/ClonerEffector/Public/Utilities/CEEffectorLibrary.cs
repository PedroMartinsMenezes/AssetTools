namespace AssetTool
{
    [JsonAsset("CEEffectorLibrary")]
    public class UCEEffectorLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}