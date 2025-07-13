namespace AssetTool
{
    [JsonAsset("TG_BlueprintFunctionLibrary")]
    public class UTG_BlueprintFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}