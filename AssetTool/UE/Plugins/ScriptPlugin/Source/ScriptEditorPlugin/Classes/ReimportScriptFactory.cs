namespace AssetTool
{
    [JsonAsset("ReimportScriptFactory")]
    public class UReimportScriptFactory : UScriptFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}