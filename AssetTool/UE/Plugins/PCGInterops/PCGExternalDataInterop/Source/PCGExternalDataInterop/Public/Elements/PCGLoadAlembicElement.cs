namespace AssetTool
{
    [JsonAsset("PCGLoadAlembicSettings")]
    public class UPCGLoadAlembicSettings : UPCGExternalDataSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}