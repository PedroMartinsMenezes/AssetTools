namespace AssetTool
{
    [JsonAsset("DMXProtocolBlueprintLibrary")]
    public class UDMXProtocolBlueprintLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}