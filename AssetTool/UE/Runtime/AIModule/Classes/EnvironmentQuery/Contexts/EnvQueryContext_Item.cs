namespace AssetTool
{
    [JsonAsset("EnvQueryContext_Item")]
    public class UEnvQueryContext_Item : UEnvQueryContext
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}