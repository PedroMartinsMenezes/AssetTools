namespace AssetTool
{
    [JsonAsset("TG_InstanceFactory")]
    public class UTG_InstanceFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}