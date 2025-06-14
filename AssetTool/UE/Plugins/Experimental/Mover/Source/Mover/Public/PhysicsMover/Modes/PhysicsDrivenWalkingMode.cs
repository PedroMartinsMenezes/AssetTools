namespace AssetTool
{
    [JsonAsset("PhysicsDrivenWalkingMode")]
    public class UPhysicsDrivenWalkingMode : UWalkingMode
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}