namespace AssetTool
{
    [JsonAsset("ConcertClientVRPresenceActor")]
    public class AConcertClientVRPresenceActor : AConcertClientPresenceActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}