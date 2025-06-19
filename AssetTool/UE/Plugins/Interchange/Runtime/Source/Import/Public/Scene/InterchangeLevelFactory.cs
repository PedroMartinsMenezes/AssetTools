namespace AssetTool
{
    [JsonAsset("InterchangeLevelFactory")]
    public class UInterchangeLevelFactory : UInterchangeFactoryBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}