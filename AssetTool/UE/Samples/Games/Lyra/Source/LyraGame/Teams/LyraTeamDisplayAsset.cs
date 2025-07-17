namespace AssetTool
{
    [JsonAsset("LyraTeamDisplayAsset")]
    public class ULyraTeamDisplayAsset : UDataAsset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}