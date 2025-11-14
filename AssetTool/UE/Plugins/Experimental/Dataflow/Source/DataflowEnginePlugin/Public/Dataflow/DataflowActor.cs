namespace AssetTool
{
    [JsonAsset("DataflowActor")]
    public class ADataflowActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}