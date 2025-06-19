namespace AssetTool
{
    [JsonAsset("EnvQueryItemType_Actor")]
    public class UEnvQueryItemType_Actor : UEnvQueryItemType_ActorBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}