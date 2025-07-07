namespace AssetTool
{
    [JsonAsset("DMXObjectBase")]
    public class UDMXObjectBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}