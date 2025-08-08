namespace AssetTool
{
    [JsonAsset("ChaosVDParticleDataComponent")]
    public class UChaosVDParticleDataComponent : UChaosVDSolverDataComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}