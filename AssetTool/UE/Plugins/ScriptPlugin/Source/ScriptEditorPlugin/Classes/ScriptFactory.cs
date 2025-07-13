namespace AssetTool
{
    [JsonAsset("ScriptFactory")]
    public class UScriptFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}