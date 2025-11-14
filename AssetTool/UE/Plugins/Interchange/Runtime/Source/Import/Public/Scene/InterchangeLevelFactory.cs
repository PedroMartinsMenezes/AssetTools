namespace AssetTool
{
    [JsonAsset("InterchangeLevelFactory")]
    public class UInterchangeLevelFactory : UInterchangeFactoryBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}