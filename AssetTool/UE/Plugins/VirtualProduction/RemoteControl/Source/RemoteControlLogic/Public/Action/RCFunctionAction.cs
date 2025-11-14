namespace AssetTool
{
    [JsonAsset("RCFunctionAction")]
    public class URCFunctionAction : URCAction
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}