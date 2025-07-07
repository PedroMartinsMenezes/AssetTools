namespace AssetTool
{
    [JsonAsset("DMXLibrary")]
    public class UDMXLibrary : UDMXObjectBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}