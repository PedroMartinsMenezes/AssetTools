namespace AssetTool
{
    [JsonAsset("ReimportScriptFactory")]
    public class UReimportScriptFactory : UScriptFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}