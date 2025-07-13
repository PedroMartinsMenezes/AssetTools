namespace AssetTool
{
    [JsonAsset("LensDistortionSolver")]
    public class ULensDistortionSolver : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LensDistortionSolverOpenCV")]
    public class ULensDistortionSolverOpenCV : ULensDistortionSolver
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}