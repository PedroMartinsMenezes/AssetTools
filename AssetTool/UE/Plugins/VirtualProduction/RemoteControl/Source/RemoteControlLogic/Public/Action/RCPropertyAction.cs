namespace AssetTool
{
    [JsonAsset("RCPropertyAction")]
    public class URCPropertyAction : URCAction
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}