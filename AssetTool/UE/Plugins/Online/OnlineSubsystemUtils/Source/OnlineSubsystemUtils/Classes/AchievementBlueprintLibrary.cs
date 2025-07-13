namespace AssetTool
{
    [JsonAsset("AchievementBlueprintLibrary")]
    public class UAchievementBlueprintLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}