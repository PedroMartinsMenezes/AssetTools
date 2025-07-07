namespace AssetTool
{
    [JsonAsset("SwitchActorFactory")]
    public class USwitchActorFactory : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}