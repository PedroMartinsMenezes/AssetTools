namespace AssetTool
{
    [JsonAsset("PhysicsThrusterComponent")]
    public class UPhysicsThrusterComponent : USceneComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}