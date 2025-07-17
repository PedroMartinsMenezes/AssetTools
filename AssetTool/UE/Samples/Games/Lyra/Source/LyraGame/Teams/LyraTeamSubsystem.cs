namespace AssetTool
{
    [JsonAsset("LyraTeamSubsystem")]
    public class ULyraTeamSubsystem : UWorldSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}