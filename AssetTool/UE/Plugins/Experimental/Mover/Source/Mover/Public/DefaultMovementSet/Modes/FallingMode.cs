namespace AssetTool
{
    [JsonAsset("FallingMode")]
    public class UFallingMode : UBaseMovementMode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}