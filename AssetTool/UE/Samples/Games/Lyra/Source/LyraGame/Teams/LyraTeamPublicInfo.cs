namespace AssetTool
{
    [JsonAsset("LyraTeamPublicInfo")]
    public class ALyraTeamPublicInfo : ALyraTeamInfoBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}