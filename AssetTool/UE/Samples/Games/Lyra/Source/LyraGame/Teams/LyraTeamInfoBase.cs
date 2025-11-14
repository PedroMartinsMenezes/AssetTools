namespace AssetTool
{
    [JsonAsset("LyraTeamInfoBase")]
    public class ALyraTeamInfoBase : AInfo
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}