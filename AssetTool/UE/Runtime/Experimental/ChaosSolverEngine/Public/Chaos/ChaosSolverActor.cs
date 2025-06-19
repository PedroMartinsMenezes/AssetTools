namespace AssetTool
{
    [JsonAsset("ChaosSolverActor")]
    public class AChaosSolverActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}