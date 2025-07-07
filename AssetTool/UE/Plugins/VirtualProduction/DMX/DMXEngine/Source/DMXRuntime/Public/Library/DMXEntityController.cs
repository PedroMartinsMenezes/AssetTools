namespace AssetTool
{
    [JsonAsset("DMXEntityUniverseManaged")]
    public class UDMXEntityUniverseManaged : UDMXEntity
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DMXEntityController")]
    public class UDMXEntityController : UDMXEntityUniverseManaged
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}