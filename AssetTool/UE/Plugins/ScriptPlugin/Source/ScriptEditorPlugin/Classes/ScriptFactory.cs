namespace AssetTool
{
    [JsonAsset("ScriptFactory")]
    public class UScriptFactory : UFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}