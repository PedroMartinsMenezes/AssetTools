namespace AssetTool
{
    [JsonAsset("CEClonerActorFactory")]
    public class UCEClonerActorFactory : UActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}