namespace AssetTool
{
    [JsonAsset("TimelineTemplate")]
    public class UTimelineTemplate : UObject
    {
        [Location("void UTimelineTemplate::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
