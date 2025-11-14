namespace AssetTool
{
    [JsonAsset("SingleKeyCaptureBehavior")]
    public class USingleKeyCaptureBehavior : UInputBehavior
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}