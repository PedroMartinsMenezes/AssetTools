namespace AssetTool
{
    [JsonAsset("NavMovementComponent")]
    public class UNavMovementComponent : UMovementComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}