namespace AssetTool
{
    [JsonAsset("ZiplineStartTransition")]
    public class UZiplineStartTransition : UBaseMovementModeTransition
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ZiplineEndTransition")]
    public class UZiplineEndTransition : UBaseMovementModeTransition
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}