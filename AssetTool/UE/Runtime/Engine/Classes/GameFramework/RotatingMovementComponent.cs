namespace AssetTool
{
    [JsonAsset("RotatingMovementComponent")]
    public class URotatingMovementComponent : UMovementComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}