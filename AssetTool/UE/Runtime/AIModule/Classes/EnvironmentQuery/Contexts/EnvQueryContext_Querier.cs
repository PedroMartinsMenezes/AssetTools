namespace AssetTool
{
    [JsonAsset("EnvQueryContext_Querier")]
    public class UEnvQueryContext_Querier : UEnvQueryContext
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}