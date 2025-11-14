namespace AssetTool
{
    [JsonAsset("WebAPIOpenAPIFactoryBase")]
    public class UWebAPIOpenAPIFactoryBase : UWebAPIDefinitionFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}