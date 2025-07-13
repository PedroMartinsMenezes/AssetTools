namespace AssetTool
{
    [JsonAsset("DataRegistryFactory")]
    public class UDataRegistryFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}