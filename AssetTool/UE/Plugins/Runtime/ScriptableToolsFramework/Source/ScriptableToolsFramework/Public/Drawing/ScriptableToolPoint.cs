namespace AssetTool
{
    [JsonAsset("ScriptableToolPoint")]
    public class UScriptableToolPoint : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}