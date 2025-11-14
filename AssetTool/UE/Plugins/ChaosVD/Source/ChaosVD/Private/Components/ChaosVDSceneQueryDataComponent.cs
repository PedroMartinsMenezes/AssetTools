namespace AssetTool
{
    [JsonAsset("ChaosVDSceneQueryDataComponent")]
    public class UChaosVDSceneQueryDataComponent : UChaosVDSolverDataComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}