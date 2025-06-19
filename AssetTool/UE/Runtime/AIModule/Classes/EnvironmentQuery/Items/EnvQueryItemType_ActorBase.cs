namespace AssetTool
{
    [JsonAsset("EnvQueryItemType_ActorBase")]
    public class UEnvQueryItemType_ActorBase : UEnvQueryItemType_VectorBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}