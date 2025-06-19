namespace AssetTool
{
    [JsonAsset("PaperTerrainActor")]
    public class APaperTerrainActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}