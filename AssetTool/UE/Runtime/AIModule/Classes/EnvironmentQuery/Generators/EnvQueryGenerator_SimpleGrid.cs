namespace AssetTool
{
    [JsonAsset("EnvQueryGenerator_SimpleGrid")]
    public class UEnvQueryGenerator_SimpleGrid : UEnvQueryGenerator_ProjectedPoints
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}