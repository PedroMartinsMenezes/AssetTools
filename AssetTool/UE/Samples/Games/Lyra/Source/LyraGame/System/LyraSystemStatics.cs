namespace AssetTool
{
    [JsonAsset("LyraSystemStatics")]
    public class ULyraSystemStatics : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}