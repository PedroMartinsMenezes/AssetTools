namespace AssetTool
{
    [JsonAsset("DMXObjectBase")]
    public class UDMXObjectBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}