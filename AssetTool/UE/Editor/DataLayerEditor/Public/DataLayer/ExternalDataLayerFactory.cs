namespace AssetTool
{
    [JsonAsset("ExternalDataLayerFactory")]
    public class UExternalDataLayerFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}