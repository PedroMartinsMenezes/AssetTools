namespace AssetTool
{
    [JsonAsset("EnvQueryGenerator_BlueprintBase")]
    public class UEnvQueryGenerator_BlueprintBase : UEnvQueryGenerator
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}