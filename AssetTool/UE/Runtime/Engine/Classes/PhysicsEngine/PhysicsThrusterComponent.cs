namespace AssetTool
{
    [JsonAsset("PhysicsThrusterComponent")]
    public class UPhysicsThrusterComponent : USceneComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}