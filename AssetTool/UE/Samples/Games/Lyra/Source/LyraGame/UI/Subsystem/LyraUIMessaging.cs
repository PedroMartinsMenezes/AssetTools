namespace AssetTool
{
    [JsonAsset("LyraUIMessaging")]
    public class ULyraUIMessaging : UCommonMessagingSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}