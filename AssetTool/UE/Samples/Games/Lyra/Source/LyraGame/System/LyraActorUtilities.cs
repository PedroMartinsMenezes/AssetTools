namespace AssetTool
{
    [JsonAsset("LyraActorUtilities")]
    public class ULyraActorUtilities : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}