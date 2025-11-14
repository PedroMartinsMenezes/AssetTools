namespace AssetTool
{
    [JsonAsset("EnvQueryItemType_ActorBase")]
    public class UEnvQueryItemType_ActorBase : UEnvQueryItemType_VectorBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}