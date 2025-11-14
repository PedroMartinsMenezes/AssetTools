namespace AssetTool
{
    [JsonAsset("RCAction")]
    public class URCAction : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}