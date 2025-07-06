namespace AssetTool
{
    [JsonAsset("RCFunctionAction")]
    public class URCFunctionAction : URCAction
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}