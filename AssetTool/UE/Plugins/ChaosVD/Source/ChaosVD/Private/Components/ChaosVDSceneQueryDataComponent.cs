namespace AssetTool
{
    [JsonAsset("ChaosVDSceneQueryDataComponent")]
    public class UChaosVDSceneQueryDataComponent : UChaosVDSolverDataComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}