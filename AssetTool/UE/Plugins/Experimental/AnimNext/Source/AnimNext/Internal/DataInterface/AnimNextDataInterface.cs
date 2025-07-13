namespace AssetTool
{
    [JsonAsset("AnimNextDataInterface")]
    public class UAnimNextDataInterface : UAnimNextRigVMAsset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}