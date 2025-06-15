namespace AssetTool
{
    [JsonAsset("EnvQueryItemType_Point")]
    public class UEnvQueryItemType_Point : UEnvQueryItemType_VectorBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}