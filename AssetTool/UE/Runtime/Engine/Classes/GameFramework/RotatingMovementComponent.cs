namespace AssetTool
{
    [JsonAsset("RotatingMovementComponent")]
    public class URotatingMovementComponent : UMovementComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}