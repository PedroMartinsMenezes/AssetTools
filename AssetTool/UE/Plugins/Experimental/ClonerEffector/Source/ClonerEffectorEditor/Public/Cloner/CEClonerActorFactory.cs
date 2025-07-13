namespace AssetTool
{
    [JsonAsset("CEClonerActorFactory")]
    public class UCEClonerActorFactory : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}