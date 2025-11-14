namespace AssetTool
{
    [JsonAsset("RCPropertyAction")]
    public class URCPropertyAction : URCAction
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}