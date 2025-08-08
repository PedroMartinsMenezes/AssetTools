namespace AssetTool
{
    [JsonAsset("PhysicsCharacterMoverComponent")]
    public class UPhysicsCharacterMoverComponent : UCharacterMoverComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}