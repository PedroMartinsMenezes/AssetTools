namespace AssetTool
{
    [JsonAsset("LevelScriptBlueprint")]
    public class ULevelScriptBlueprint : UBlueprint
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}