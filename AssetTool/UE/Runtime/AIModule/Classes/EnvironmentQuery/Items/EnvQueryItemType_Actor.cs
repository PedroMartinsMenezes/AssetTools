namespace AssetTool
{
    [JsonAsset("EnvQueryItemType_Actor")]
    public class UEnvQueryItemType_Actor : UEnvQueryItemType_ActorBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}