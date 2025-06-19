namespace AssetTool
{
    [JsonAsset("EnvQueryContext")]
    public class UEnvQueryContext : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}