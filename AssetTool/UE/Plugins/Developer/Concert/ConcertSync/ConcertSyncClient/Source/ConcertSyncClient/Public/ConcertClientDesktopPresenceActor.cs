namespace AssetTool
{
    [JsonAsset("ConcertClientDesktopPresenceActor")]
    public class AConcertClientDesktopPresenceActor : AConcertClientPresenceActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}