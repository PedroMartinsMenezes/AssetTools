namespace AssetTool
{
    [JsonAsset("ConcertClientVRPresenceActor")]
    public class AConcertClientVRPresenceActor : AConcertClientPresenceActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}