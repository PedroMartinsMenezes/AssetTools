namespace AssetTool
{
    [JsonAsset("EnvQueryItemType_Direction")]
    public class UEnvQueryItemType_Direction : UEnvQueryItemType_VectorBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}