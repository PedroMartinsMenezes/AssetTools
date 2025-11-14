namespace AssetTool
{
    [JsonAsset("DeformableSolverActor")]
    public class ADeformableSolverActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}