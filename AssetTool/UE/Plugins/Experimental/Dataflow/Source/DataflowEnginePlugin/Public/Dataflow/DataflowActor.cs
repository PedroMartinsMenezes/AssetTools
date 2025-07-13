namespace AssetTool
{
    [JsonAsset("DataflowActor")]
    public class ADataflowActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}