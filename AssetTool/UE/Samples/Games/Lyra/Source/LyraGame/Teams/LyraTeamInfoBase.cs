namespace AssetTool
{
    [JsonAsset("LyraTeamInfoBase")]
    public class ALyraTeamInfoBase : AInfo
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}