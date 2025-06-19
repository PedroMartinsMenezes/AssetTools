namespace AssetTool
{
    [JsonAsset("ObjectRedirector")]
    public class UObjectRedirector : UObject
    {
        public UInt32 DestinationObject;

        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref DestinationObject);
            return this;
        }
    }
}
