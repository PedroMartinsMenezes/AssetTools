namespace AssetTool
{
    [JsonAsset("EnvQueryGenerator_Donut")]
    public class UEnvQueryGenerator_Donut : UEnvQueryGenerator_ProjectedPoints
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}