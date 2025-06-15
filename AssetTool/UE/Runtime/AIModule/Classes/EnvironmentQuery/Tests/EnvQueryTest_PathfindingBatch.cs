namespace AssetTool
{
    [JsonAsset("EnvQueryTest_PathfindingBatch")]
    public class UEnvQueryTest_PathfindingBatch : UEnvQueryTest_Pathfinding
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}