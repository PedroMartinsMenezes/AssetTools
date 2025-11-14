namespace AssetTool
{
    [JsonAsset("LyraTeamPrivateInfo")]
    public class ALyraTeamPrivateInfo : ALyraTeamInfoBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}