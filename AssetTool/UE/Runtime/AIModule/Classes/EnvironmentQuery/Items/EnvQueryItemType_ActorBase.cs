namespace AssetTool
{
    [JsonAsset("EnvQueryItemType_ActorBase")]
    public class UEnvQueryItemType_ActorBase : UEnvQueryItemType_VectorBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}