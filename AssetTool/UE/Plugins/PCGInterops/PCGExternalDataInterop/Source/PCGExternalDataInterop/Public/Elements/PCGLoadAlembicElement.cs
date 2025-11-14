namespace AssetTool
{
    [JsonAsset("PCGLoadAlembicSettings")]
    public class UPCGLoadAlembicSettings : UPCGExternalDataSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}