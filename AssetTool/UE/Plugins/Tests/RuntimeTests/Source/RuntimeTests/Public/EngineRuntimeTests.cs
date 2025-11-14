namespace AssetTool
{
    [JsonAsset("EngineTestTickActor")]
    public class AEngineTestTickActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}