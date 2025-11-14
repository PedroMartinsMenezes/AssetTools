namespace AssetTool
{
    [JsonAsset("EnvQueryTest_PathfindingBatch")]
    public class UEnvQueryTest_PathfindingBatch : UEnvQueryTest_Pathfinding
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}