namespace AssetTool
{
    [JsonAsset("MockFlyingAbilityComponent")]
    public class UMockFlyingAbilityComponent : UFlyingMovementComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}