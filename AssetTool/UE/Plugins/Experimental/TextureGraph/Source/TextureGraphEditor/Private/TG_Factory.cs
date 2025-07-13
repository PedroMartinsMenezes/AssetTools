namespace AssetTool
{
    [JsonAsset("TG_Factory")]
    public class UTG_Factory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}