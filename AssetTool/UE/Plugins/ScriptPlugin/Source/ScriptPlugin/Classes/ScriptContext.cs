namespace AssetTool
{
    [JsonAsset("ScriptContext")]
    public class UScriptContext : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}