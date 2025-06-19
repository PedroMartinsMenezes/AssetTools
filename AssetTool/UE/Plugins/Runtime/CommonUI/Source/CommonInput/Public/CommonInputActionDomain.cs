namespace AssetTool
{
    [JsonAsset("CommonInputActionDomain")]
    public class UCommonInputActionDomain : UDataAsset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CommonInputActionDomainTable")]
    public class UCommonInputActionDomainTable : UDataAsset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}