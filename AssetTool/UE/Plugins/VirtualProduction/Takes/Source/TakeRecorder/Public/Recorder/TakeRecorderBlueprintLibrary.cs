namespace AssetTool
{
    [JsonAsset("TakeRecorderBlueprintLibrary")]
    public class UTakeRecorderBlueprintLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}