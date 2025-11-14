namespace AssetTool
{
    [JsonAsset("LevelScriptBlueprint")]
    public class ULevelScriptBlueprint : UBlueprint
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}