namespace AssetTool
{
    [JsonAsset("AnimNextDataInterface")]
    public class UAnimNextDataInterface : UAnimNextRigVMAsset
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}