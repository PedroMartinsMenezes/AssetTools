namespace AssetTool
{
    [JsonAsset("EnvQueryItemType_Point")]
    public class UEnvQueryItemType_Point : UEnvQueryItemType_VectorBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}