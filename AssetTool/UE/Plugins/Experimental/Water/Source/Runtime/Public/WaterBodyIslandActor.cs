namespace AssetTool
{
    [JsonAsset("WaterBodyIsland")]
    public class AWaterBodyIsland : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}