namespace AssetTool
{
    [JsonAsset("DataLayerFactory")]
    public class UDataLayerFactory : UFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}