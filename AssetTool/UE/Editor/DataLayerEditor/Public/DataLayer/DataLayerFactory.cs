namespace AssetTool
{
    [JsonAsset("DataLayerFactory")]
    public class UDataLayerFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}