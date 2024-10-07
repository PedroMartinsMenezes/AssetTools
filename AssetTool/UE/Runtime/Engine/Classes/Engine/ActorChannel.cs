namespace AssetTool
{
    [JsonAsset("ActorChannel")]
    public class UActorChannel : UChannel
    {
        [Location("void UActorChannel::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
