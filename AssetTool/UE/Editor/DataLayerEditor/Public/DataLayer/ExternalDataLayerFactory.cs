namespace AssetTool
{
    [JsonAsset("ExternalDataLayerFactory")]
    public class UExternalDataLayerFactory : UFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}