namespace AssetTool
{
    [JsonAsset("EnvQueryGenerator_PerceivedActors")]
    public class UEnvQueryGenerator_PerceivedActors : UEnvQueryGenerator
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}