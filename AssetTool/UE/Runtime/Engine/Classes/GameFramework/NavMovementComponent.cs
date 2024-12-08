namespace AssetTool
{
    [JsonAsset("NavMovementComponent")]
    public class UNavMovementComponent : UMovementComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}