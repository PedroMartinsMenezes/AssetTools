namespace AssetTool
{
    [JsonAsset("PhysicsCharacterMoverComponent")]
    public class UPhysicsCharacterMoverComponent : UCharacterMoverComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}