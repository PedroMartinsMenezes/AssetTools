namespace AssetTool
{
    [JsonAsset("PaperTerrainActor")]
    public class APaperTerrainActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}