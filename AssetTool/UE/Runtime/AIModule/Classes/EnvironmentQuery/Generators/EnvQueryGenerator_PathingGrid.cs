namespace AssetTool
{
    [JsonAsset("EnvQueryGenerator_PathingGrid")]
    public class UEnvQueryGenerator_PathingGrid : UEnvQueryGenerator_SimpleGrid
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}