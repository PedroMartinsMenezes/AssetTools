namespace AssetTool
{
    [JsonAsset("DMXEntity")]
    public class UDMXEntity : UDMXObjectBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}