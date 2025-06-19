namespace AssetTool
{
    [JsonAsset("AvaBroadcastLibrary")]
    public class UAvaBroadcastLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}