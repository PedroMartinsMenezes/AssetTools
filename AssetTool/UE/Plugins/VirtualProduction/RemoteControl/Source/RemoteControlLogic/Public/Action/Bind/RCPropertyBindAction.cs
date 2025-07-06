namespace AssetTool
{
    [JsonAsset("RCPropertyBindAction")]
    public class URCPropertyBindAction : URCPropertyAction
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}