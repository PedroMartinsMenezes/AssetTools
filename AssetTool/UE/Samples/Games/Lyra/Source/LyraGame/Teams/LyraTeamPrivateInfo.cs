namespace AssetTool
{
    [JsonAsset("LyraTeamPrivateInfo")]
    public class ALyraTeamPrivateInfo : ALyraTeamInfoBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}