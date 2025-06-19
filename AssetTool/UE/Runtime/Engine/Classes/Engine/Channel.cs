namespace AssetTool
{
    [JsonAsset("Channel")]
    public class UChannel : UObject
    {
        [Location("void UChannel::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
