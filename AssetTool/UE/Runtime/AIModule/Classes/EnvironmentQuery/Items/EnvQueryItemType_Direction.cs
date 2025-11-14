namespace AssetTool
{
    [JsonAsset("EnvQueryItemType_Direction")]
    public class UEnvQueryItemType_Direction : UEnvQueryItemType_VectorBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}