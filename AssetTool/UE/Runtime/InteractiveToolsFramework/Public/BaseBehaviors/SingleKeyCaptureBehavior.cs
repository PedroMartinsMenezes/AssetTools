namespace AssetTool
{
    [JsonAsset("SingleKeyCaptureBehavior")]
    public class USingleKeyCaptureBehavior : UInputBehavior
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}