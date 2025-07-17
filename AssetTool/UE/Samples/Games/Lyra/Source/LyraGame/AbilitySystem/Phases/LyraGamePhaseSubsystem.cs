namespace AssetTool
{
    [JsonAsset("LyraGamePhaseSubsystem")]
    public class ULyraGamePhaseSubsystem : UWorldSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}