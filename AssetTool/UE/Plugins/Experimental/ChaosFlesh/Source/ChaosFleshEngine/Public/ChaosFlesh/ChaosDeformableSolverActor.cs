namespace AssetTool
{
    [JsonAsset("DeformableSolverActor")]
    public class ADeformableSolverActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}