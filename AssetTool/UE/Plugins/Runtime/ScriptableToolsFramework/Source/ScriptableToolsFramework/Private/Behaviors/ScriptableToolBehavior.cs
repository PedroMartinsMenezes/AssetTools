namespace AssetTool
{
    [JsonAsset("ScriptableToolBehavior")]
    public class UScriptableToolBehavior : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}