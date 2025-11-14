namespace AssetTool
{
    [JsonAsset("PhysicsDrivenWalkingMode")]
    public class UPhysicsDrivenWalkingMode : UWalkingMode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}