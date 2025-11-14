namespace AssetTool
{
    [JsonAsset("RCPropertyBindAction")]
    public class URCPropertyBindAction : URCPropertyAction
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}