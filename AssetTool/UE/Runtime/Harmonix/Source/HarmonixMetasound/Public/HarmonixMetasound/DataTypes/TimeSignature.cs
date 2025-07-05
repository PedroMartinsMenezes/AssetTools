namespace AssetTool
{
    [JsonAsset("TimeSignatureBlueprintLibrary")]
    public class UTimeSignatureBlueprintLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}