namespace AssetTool
{
    [JsonAsset("CEEffectorLibrary")]
    public class UCEEffectorLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}