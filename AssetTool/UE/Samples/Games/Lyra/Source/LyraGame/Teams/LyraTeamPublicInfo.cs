namespace AssetTool
{
    [JsonAsset("LyraTeamPublicInfo")]
    public class ALyraTeamPublicInfo : ALyraTeamInfoBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}