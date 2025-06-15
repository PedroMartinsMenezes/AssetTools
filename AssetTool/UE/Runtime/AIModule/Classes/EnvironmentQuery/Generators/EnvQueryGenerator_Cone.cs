namespace AssetTool
{
    [JsonAsset("EnvQueryGenerator_Cone")]
    public class UEnvQueryGenerator_Cone : UEnvQueryGenerator_ProjectedPoints
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}