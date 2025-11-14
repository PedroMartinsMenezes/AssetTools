namespace AssetTool
{
    [JsonAsset("ZipliningMode")]
    public class UZipliningMode : UBaseMovementMode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}