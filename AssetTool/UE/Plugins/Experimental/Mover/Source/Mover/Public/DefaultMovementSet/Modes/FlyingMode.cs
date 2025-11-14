namespace AssetTool
{
    [JsonAsset("FlyingMode")]
    public class UFlyingMode : UBaseMovementMode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}