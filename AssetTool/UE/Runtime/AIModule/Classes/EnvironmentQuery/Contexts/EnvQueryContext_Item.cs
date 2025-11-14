namespace AssetTool
{
    [JsonAsset("EnvQueryContext_Item")]
    public class UEnvQueryContext_Item : UEnvQueryContext
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}