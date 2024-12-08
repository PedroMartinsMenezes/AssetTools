namespace AssetTool
{
    [JsonAsset("LevelScriptBlueprint")]
    public class ULevelScriptBlueprint : UBlueprint
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}