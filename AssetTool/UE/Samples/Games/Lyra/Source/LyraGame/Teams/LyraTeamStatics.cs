namespace AssetTool
{
    [JsonAsset("LyraTeamStatics")]
    public class ULyraTeamStatics : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}