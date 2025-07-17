namespace AssetTool
{
    [JsonAsset("LyraTeamCheats")]
    public class ULyraTeamCheats : UCheatManagerExtension
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}