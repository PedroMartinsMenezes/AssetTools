namespace AssetTool
{
    [JsonAsset("DMXEntity")]
    public class UDMXEntity : UDMXObjectBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}