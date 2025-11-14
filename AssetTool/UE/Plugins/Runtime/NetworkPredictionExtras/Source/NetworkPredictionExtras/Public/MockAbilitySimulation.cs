namespace AssetTool
{
    [JsonAsset("MockFlyingAbilityComponent")]
    public class UMockFlyingAbilityComponent : UFlyingMovementComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}