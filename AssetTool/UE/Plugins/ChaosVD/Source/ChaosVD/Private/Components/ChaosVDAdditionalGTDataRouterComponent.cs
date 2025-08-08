namespace AssetTool
{
    [JsonAsset("ChaosVDAdditionalGTDataRouterComponent")]
    public class UChaosVDAdditionalGTDataRouterComponent : UChaosVDSolverDataComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}