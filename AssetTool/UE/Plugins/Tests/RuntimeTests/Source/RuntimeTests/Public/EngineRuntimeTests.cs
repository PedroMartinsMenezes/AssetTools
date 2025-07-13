namespace AssetTool
{
    [JsonAsset("EngineTestTickActor")]
    public class AEngineTestTickActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}