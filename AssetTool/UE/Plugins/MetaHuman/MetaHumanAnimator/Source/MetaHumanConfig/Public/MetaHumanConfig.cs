namespace AssetTool
{
    [JsonAsset("MetaHumanConfig")]
    public class UMetaHumanConfig : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}