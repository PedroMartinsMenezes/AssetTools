namespace AssetTool
{
    [JsonAsset("InterchangeLevelSequenceFactory")]
    public class UInterchangeLevelSequenceFactory : UInterchangeFactoryBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}