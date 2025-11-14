namespace AssetTool
{
    [JsonAsset("DMXEntityUniverseManaged")]
    public class UDMXEntityUniverseManaged : UDMXEntity
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DMXEntityController")]
    public class UDMXEntityController : UDMXEntityUniverseManaged
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}