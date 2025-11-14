namespace AssetTool
{
    [JsonAsset("RCBehaviour")]
    public class URCBehaviour : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}