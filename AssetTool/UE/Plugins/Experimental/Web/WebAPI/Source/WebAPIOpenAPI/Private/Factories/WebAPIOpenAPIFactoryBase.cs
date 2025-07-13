namespace AssetTool
{
    [JsonAsset("WebAPIOpenAPIFactoryBase")]
    public class UWebAPIOpenAPIFactoryBase : UWebAPIDefinitionFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}