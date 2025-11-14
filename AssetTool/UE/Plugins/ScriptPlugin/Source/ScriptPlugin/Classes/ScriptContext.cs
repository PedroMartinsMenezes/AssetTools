namespace AssetTool
{
    [JsonAsset("ScriptContext")]
    public class UScriptContext : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}