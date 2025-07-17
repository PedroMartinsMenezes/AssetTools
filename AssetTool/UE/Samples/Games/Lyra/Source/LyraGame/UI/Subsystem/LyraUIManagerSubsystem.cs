namespace AssetTool
{
    [JsonAsset("LyraUIManagerSubsystem")]
    public class ULyraUIManagerSubsystem : UGameUIManagerSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}