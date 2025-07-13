namespace AssetTool
{
    [JsonAsset("ScriptableToolSet")]
    public class UScriptableToolSet : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}