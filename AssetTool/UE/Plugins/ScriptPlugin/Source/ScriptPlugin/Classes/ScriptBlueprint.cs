namespace AssetTool
{
    [JsonAsset("ScriptBlueprint")]
    public class UScriptBlueprint : UBlueprint
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}