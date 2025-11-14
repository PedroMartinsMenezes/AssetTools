namespace AssetTool
{
    [JsonAsset("ConcertClientDesktopPresenceActor")]
    public class AConcertClientDesktopPresenceActor : AConcertClientPresenceActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}