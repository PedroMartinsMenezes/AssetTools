namespace AssetTool
{
    [JsonAsset("ScriptBlueprint")]
    public class UScriptBlueprint : UBlueprint
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}