namespace AssetTool
{
    [JsonAsset("ScriptableToolBehavior")]
    public class UScriptableToolBehavior : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}