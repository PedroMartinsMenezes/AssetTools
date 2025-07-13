namespace AssetTool
{
    [JsonAsset("WebAPIDefinitionFactory")]
    public class UWebAPIDefinitionFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}