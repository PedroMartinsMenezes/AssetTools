namespace AssetTool
{
    [JsonAsset("PhysicsDrivenWalkingMode")]
    public class UPhysicsDrivenWalkingMode : UWalkingMode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}