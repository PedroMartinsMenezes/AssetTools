namespace AssetTool
{
    [JsonAsset("EnvQueryContext_BlueprintBase")]
    public class UEnvQueryContext_BlueprintBase : UEnvQueryContext
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}