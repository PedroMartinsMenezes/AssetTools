namespace AssetTool
{
    [JsonAsset("MediaBlueprintFunctionLibrary")]
    public class UMediaBlueprintFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}